using AutoMapper;
using BusinessObjects.Context;
using BusinessObjects.DTO.Bill;
using BusinessObjects.DTO.BillReqRes;
using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation
{
    public class BillService(
        IMapper mapper,
        IBillRepository billRepository,
        IBillPromotionRepository billPromotionRepository,
        IBillJewelryRepository billJewelryRepository,
        IPromotionRepository promotionRepository,
        IBillDetailRepository billDetailRepository,
        ICustomerRepository customerRepository,
        IUserRepository userRepository,
        IJewelryRepository jewelryRepository,
        JssatsContext _context) : IBillService
    {

        public JssatsContext Context { get; } = _context;
        public IMapper Mapper { get; } = mapper;
        private IBillRepository BillRepository { get; } = billRepository;
        public IBillPromotionRepository BillPromotionRepository { get; } = billPromotionRepository;
        public IBillJewelryRepository BillJewelryRepository { get; } = billJewelryRepository;
        public IPromotionRepository PromotionRepository { get; } = promotionRepository;
        public IBillDetailRepository BillDetailRepository { get; } = billDetailRepository;
        public ICustomerRepository CustomerRepository { get; } = customerRepository;
        public IUserRepository UserRepository { get; } = userRepository;
        public IJewelryRepository JewelryRepository { get; } = jewelryRepository;

        public async Task<BillResponseDto> Create(BillRequestDto billRequestDto)
        {
            double totalAmount = 0;
            double totalDiscountRate = 0;
            double finalAmount = 0;

            // Create bill
            var bill = new Bill
            {
                CustomerId = billRequestDto.CustomerId,
                UserId = billRequestDto.UserId,
                CounterId = billRequestDto.CounterId,
                SaleDate = DateTime.Now.ToUniversalTime(),
                CreatedAt = DateTime.Now.ToUniversalTime(),
                UpdatedAt = DateTime.Now.ToUniversalTime(),
            };

            // lấy ra danh sách các sản phẩm có trong database từ billRequestDto
            var jewelries = await Context.Jewelries
                        .Where(j => billRequestDto.Jewelries.Select(j => j.JewelryId).Contains(j.JewelryId))
                        .Include(j => j.JewelryType)
                        .Include(j => j.JewelryMaterials)
                            .ThenInclude(jm => jm.Gem)
                        .Include(j => j.JewelryMaterials)
                            .ThenInclude(jm => jm.Gold)
                        .ToListAsync();

            // lấy ra danh sách các khuyến mãi có trong database từ billRequestDto
            var promotions = new List<Promotion>();
            if (billRequestDto.Promotions != null && billRequestDto.Promotions.Count() > 0)
            {
                promotions = Context.Promotions
                    .Where(p => billRequestDto.Promotions.Select(p => p.PromotionId).Contains(p.PromotionId)).ToList();

            }

            // kiểm tra xem danh sách sản phẩm và khuyến mãi có tồn tại trong database không
            if (jewelries.Count != billRequestDto.Jewelries.Count() || promotions.Count != billRequestDto.Promotions.Count())
            {
                throw new Exception("Some items are not found in database");
            }

            // Build billJewelries
            foreach (var item in jewelries)
            {
                var quantity = billRequestDto.Jewelries.First(j => j.JewelryId == item.JewelryId).Quantity;
                var material = item.JewelryMaterials.FirstOrDefault();
                var billJewelry = new BillJewelry
                {
                    JewelryId = item.JewelryId,
                    Quantity = quantity,
                    LaborCost = item.LaborCost,
                    GemSellPrice = material.Gem.SellPrice,
                    GoldSellPrice = material.Gold.SellPrice,
                    GoldWeight = material.GoldWeight,
                    StoneQuantity = material.StoneQuantity,
                    CreatedAt = DateTime.Now.ToUniversalTime(),
                    UpdatedAt = DateTime.Now.ToUniversalTime()
                };
                // totalPrice = [giá vàng thời điểm * trọng lượng sản phẩm] + tiền công + tiền đá
                billJewelry.TotalAmount = (billJewelry.GoldSellPrice * billJewelry.GoldWeight) + billJewelry.LaborCost + (billJewelry.GemSellPrice * billJewelry.StoneQuantity);
                billJewelry.TotalAmount *= quantity; // nếu có nhiều sản phẩm cùng loại
                bill.TotalAmount += billJewelry.TotalAmount; // tổng tiền của bill
                bill.BillJewelries.Add(billJewelry);
            }

            // nếu có promotion thì nhân với discount rate
            foreach (var promotion in promotions)
            {
                bill.TotalAmount *= (1 - promotion.DiscountRate / 100);
            }

            var transaction = Context.Database.BeginTransaction();
            try
            {
                // Build Bill
                var billId = await Context.Bills.AddAsync(bill);
                await Context.SaveChangesAsync();

                // Build BillPromotions
                var billPromotions = new List<BillPromotion>();
                foreach (var promotion in promotions)
                {
                    var billPromotion = new BillPromotion
                    {
                        BillId = billId.Entity.BillId,
                        PromotionId = promotion.PromotionId
                    };
                    billPromotions.Add(billPromotion);
                }
                await Context.BillPromotions.AddRangeAsync(billPromotions);
                await Context.SaveChangesAsync();

                // Build Warranty
                var warranties = new List<Warranty>();
                foreach (var item in jewelries)
                {
                    var warrantyMonth = item.WarrantyTime;
                    var quantity = billRequestDto.Jewelries.First(j => j.JewelryId == item.JewelryId).Quantity;
                    if (warrantyMonth != null)
                    {
                        for (int i = 0; i < quantity; i++)
                        {
                            var warranty = new Warranty
                            {
                                BillId = billId.Entity.BillId,
                                CustomerId = billRequestDto.CustomerId,
                                EndDate = DateTime.Now.AddMonths(warrantyMonth.Value).ToUniversalTime(),
                                JewelryId = item.JewelryId
                            };
                            warranties.Add(warranty);
                        }
                    }
                }
                if (warranties.Count > 0)
                {
                    await Context.Warranties.AddRangeAsync(warranties);
                    await Context.SaveChangesAsync();
                }

                transaction.Commit();
            }
            catch (System.Exception)
            {
                transaction.Rollback();
                throw;
            }
            var a = new BillResponseDto
            {
                Items = null,
                Promotions = null,
            };
            return a;
        }


        public async Task<IEnumerable<BillDetailDto?>?> GetBills()
        {
            return await BillDetailRepository.GetBillDetails();
        }

        public async Task<BillDetailDto?> GetById(int id)
        {
            return await BillDetailRepository.GetBillDetail(id);
        }

        private static double CalculateFinalAmount(double totalAmount, double discountRate)
        {
            return totalAmount - (totalAmount * (discountRate / 100));
        }
    }
}
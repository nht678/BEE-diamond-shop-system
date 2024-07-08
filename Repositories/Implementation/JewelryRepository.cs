using BusinessObjects.DTO.ResponseDto;
using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class JewelryRepository(
        JewelryDao jewelryDao,
        JewelryTypeDao jewelryTypeDao,
        GoldPriceDao goldPriceDao,
        GemPriceDao gemPriceDao,
        JewelryMaterialDao jewelryMaterialDao) : IJewelryRepository
    {
        public JewelryDao JewelryDao { get; } = jewelryDao;
        public JewelryTypeDao JewelryTypeDao { get; } = jewelryTypeDao;
        public GoldPriceDao GoldPriceDao { get; } = goldPriceDao;
        public GemPriceDao GemPriceDao { get; } = gemPriceDao;
        public JewelryMaterialDao JewelryMaterialDao { get; } = jewelryMaterialDao;

        public async Task<int> Create(Jewelry entity)
        {
            entity.IsSold = false;
            return await JewelryDao.CreateJewelry(entity);
        }

        public async Task<int> Delete(int id)
        {
            return await JewelryDao.DeleteJewelry(id);
        }

        public async Task<IEnumerable<JewelryResponseDto>?> Gets()
        {
            var jewelries = await JewelryDao.GetJewelries();
            if (jewelries == null || !jewelries.Any())
            {
                return null;
            }

            var jewelryResponseDtos = new List<JewelryResponseDto>();

            foreach (var jewelry in jewelries)
            {
                var jewelryType = await JewelryTypeDao.GetJewelryTypeById(jewelry.JewelryTypeId);
                var jewelryMaterials = await JewelryMaterialDao.GetJewelryMaterialByJewelry(jewelry.JewelryId);
                var jewelryMaterialList = new List<JewelryMaterial> { jewelryMaterials };
                foreach (var jewelryMaterial in jewelryMaterialList)
                {
                    var goldType = await GoldPriceDao.GetGoldPriceById(jewelryMaterial.GoldId);
                    var stoneType = await GemPriceDao.GetStonePriceById(jewelryMaterial.GemId);

                    jewelryMaterial.Gold = goldType;
                    jewelryMaterial.Gem = stoneType;
                }

                jewelry.JewelryType = jewelryType;
                jewelry.JewelryMaterials = jewelryMaterialList;

                var totalPrice = jewelry.JewelryMaterials.Sum(jm => CalculateTotalPrice(jm, jewelry.LaborCost));

                var jewelryResponseDto = new JewelryResponseDto
                {
                    JewelryId = jewelry.JewelryId,
                    Name = jewelry.Name,
                    Type = jewelryType.Name,
                    Barcode = jewelry.Barcode,
                    LaborCost = jewelry.LaborCost,
                    Materials = jewelry.JewelryMaterials.Select(jm => new Materials
                    {
                        Gold = new GoldResponseDto
                        {
                            GoldType = jm.Gold?.Type,
                            GoldQuantity = jm.GoldWeight,
                            GoldPrice = jm.Gold?.SellPrice ?? 0
                        },
                        Gem = new GemResponseDto
                        {
                            Gem = jm.Gem?.Type,
                            GemQuantity = jm.StoneQuantity,
                            GemPrice = jm.Gem?.SellPrice ?? 0
                        }
                    }).ToList(),
                    TotalPrice = totalPrice
                };

                jewelryResponseDtos.Add(jewelryResponseDto);
            }

            return jewelryResponseDtos;
        }

        public async Task<JewelryResponseDto> GetById(int id)
        {
            var jewelry = await JewelryDao.GetJewelryById(id);
            var jewelryType = await JewelryTypeDao.GetJewelryTypeById(jewelry.JewelryTypeId);
            var jewelryMaterial = await JewelryMaterialDao.GetJewelryMaterialByJewelry(id);
            var goldType = await GoldPriceDao.GetGoldPriceById(jewelryMaterial.GoldId);
            var stoneType = await GemPriceDao.GetStonePriceById(jewelryMaterial.GemId);

            jewelryMaterial.Gold = goldType;
            jewelryMaterial.Gem = stoneType;
            jewelry.JewelryType = jewelryType;
            jewelry.JewelryMaterials = new List<JewelryMaterial> { jewelryMaterial };

            var totalPrice = CalculateTotalPrice(jewelryMaterial, jewelry.LaborCost);

            var jewelryResponseDto = new JewelryResponseDto
            {
                JewelryId = jewelry.JewelryId,
                Name = jewelry.Name,
                Type = jewelryType.Name,
                Barcode = jewelry.Barcode,
                JewelryPrice = CalculateJewelryPrice(jewelryMaterial),
                LaborCost = jewelry.LaborCost,
                Materials = jewelry.JewelryMaterials.Select(jm => new Materials
                {
                    Gold = new GoldResponseDto
                    {
                        GoldType = jm.Gold?.Type,
                        GoldQuantity = jm.GoldWeight,
                        GoldPrice = jm.Gold?.SellPrice ?? 0
                    },
                    Gem = new GemResponseDto
                    {
                        Gem = jm.Gem?.Type,
                        GemQuantity = jm.StoneQuantity,
                        GemPrice = jm.Gem?.SellPrice ?? 0
                    }
                }).ToList(),
                TotalPrice = totalPrice
            };

            return jewelryResponseDto;
        }

        public async Task<int> Update(int id, Jewelry entity)
        {
            return await JewelryDao.UpdateJewelry(id, entity);
        }

        private static float CalculateTotalPrice(JewelryMaterial jewelryMaterial, double? laborCost)
        {
            float totalPrice = 0;
            if (jewelryMaterial.Gold != null)
            {
                totalPrice += jewelryMaterial.Gold.BuyPrice * jewelryMaterial.GoldWeight;
            }

            if (jewelryMaterial.Gem != null)
            {
                totalPrice += jewelryMaterial.Gem.BuyPrice * jewelryMaterial.StoneQuantity;
            }

            totalPrice += (float)laborCost;
            return totalPrice;
        }

        private static float CalculateJewelryPrice(JewelryMaterial jewelryMaterial)
        {
            float totalPrice = 0;
            if (jewelryMaterial.Gold != null)
            {
                totalPrice += jewelryMaterial.Gold.BuyPrice * jewelryMaterial.GoldWeight;
            }

            if (jewelryMaterial.Gem != null)
            {
                totalPrice += jewelryMaterial.Gem.BuyPrice * jewelryMaterial.StoneQuantity;
            }

            return totalPrice;
        }
    }
}
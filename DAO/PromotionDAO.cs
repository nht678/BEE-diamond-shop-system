using BusinessObjects.Context;
using BusinessObjects.Models;
using DAO.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class PromotionDao : Singleton<PromotionDao>
    {
        private readonly JssatsContext _context;

        public PromotionDao()
        {
            _context = new JssatsContext();
        }

        public async Task<IEnumerable<Promotion>> GetPromotions()
        {
            return await _context.Promotions.ToListAsync();
        }
        public async Task<Promotion?> GetPromotionById(int id)
        {
            return await _context.Promotions.FindAsync(id);
        }
        public async Task<int> CreatePromotion(Promotion promotion)
        {
            await _context.Promotions.AddAsync(promotion);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdatePromotion(int id, Promotion promotion)
        {
            var existPromotion = await _context.Promotions.FirstOrDefaultAsync(x => x.PromotionId == id);
            if (existPromotion == null) return 0;
            existPromotion.Type = promotion.Type;
            existPromotion.Description = promotion.Description;
            existPromotion.EndDate = promotion.EndDate;
            existPromotion.StartDate = promotion.StartDate;
            existPromotion.ApproveManager = promotion.ApproveManager;
            existPromotion.DiscountRate = promotion.DiscountRate;
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeletePromotion(int id)
        {
            var existPromotion = await _context.Promotions.FirstOrDefaultAsync(x => x.PromotionId == id);
            if (existPromotion == null) return 0;
            _context.Remove(existPromotion);
            return await _context.SaveChangesAsync();
        }
    }
}
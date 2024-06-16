﻿using BusinessObjects.Models;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class PromotionRepository(PromotionDao promotionDao) : IPromotionRepository
    {
        public PromotionDao PromotionDao { get; } = promotionDao;

        public async Task<int> Create(Promotion promotion)
        {
            var result = await PromotionDao.CreatePromotion(promotion);
            return result;
        }

        public async Task<int> Delete(string id)
        {
            return await PromotionDao.DeletePromotion(id);
        }

        public async Task<IEnumerable<Promotion?>?> Gets()
        {
            return await PromotionDao.GetPromotions();
        }

        public Task<Promotion?> GetById(string id)
        {
            return PromotionDao.GetPromotionById(id);
        }

        public async Task<int> Update(string id, Promotion promotion)
        {
            return await PromotionDao.UpdatePromotion(id, promotion);
        }
    }
}

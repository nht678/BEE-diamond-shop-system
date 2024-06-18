﻿using BusinessObjects.Models;
using DAO;
using Repositories.Interface;
using Repositories.Interface.GenericRepository;

namespace Repositories.Implementation;

public class BillJewelryRepository(BillJewelryDao billJewelryDao) : IBillJewelryRepository
{
    public BillJewelryDao BillJewelryDao { get; } = billJewelryDao;

    public async Task<int> Create(BillJewelry entity)
    {
        return await BillJewelryDao.CreateBillJewelry(entity);
    }
}
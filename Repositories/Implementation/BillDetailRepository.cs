﻿using BusinessObjects.DTO.BillReqRes;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Repositories.Implementation;

public class BillDetailRepository : IBillDetailRepository
{
    private readonly IMongoCollection<BillDetailDto> _collection;

    public BillDetailRepository(IMongoClient client, IConfiguration configuration)
    {
        var databaseName = configuration.GetSection("MongoDb:DatabaseName:JSSATS").Value;
        var database = client.GetDatabase(databaseName);
        _collection = database.GetCollection<BillDetailDto>("BillDetail");
    }

    public async Task AddBillDetail(BillDetailDto billDetail)
    {
        await _collection.InsertOneAsync(billDetail);
    }

    public async Task<IEnumerable<BillDetailDto>> GetBillDetails()
    {
        return await _collection.Find(x => true).ToListAsync();
    }

    public async Task<BillDetailDto> GetBillDetail(int billId)
    {
        return await _collection.Find(x => x.BillId == billId).FirstOrDefaultAsync();
    }
}
﻿using BusinessObjects.DTO.Bill;
using BusinessObjects.Models;

namespace Services.Interface
{
    public interface IBillService
    {
        public Task<BillResponseDto> Create(BillRequestDto entity);
        public Task<IEnumerable<Bill?>?> GetBills();
        public Task<Bill?> GetById(string id);
    }
}

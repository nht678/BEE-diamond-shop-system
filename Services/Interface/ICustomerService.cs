﻿using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.DTO;
using BusinessObjects.DTO.ResponseDto;

namespace Services.Interface
{
    public interface ICustomerService
    {
        public Task<IEnumerable<CustomerResponseDto?>?> GetCustomers();
        public Task<CustomerResponseDto?> GetCustomerById(string id);
        public Task<int> CreateCustomer(CustomerDto customer);
        public Task<int> UpdateCustomer(string id,CustomerDto customer);
        public Task<int> DeleteCustomer(string id);
    }
}

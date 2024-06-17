﻿using BusinessObjects.DTO.Bill;
using Management.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BillController(IUserManagement userManagement) : ControllerBase
{
    private IUserManagement UserManagement { get; } = userManagement;
    
    [Authorize]
    [HttpGet("GetBills")]
    public async Task<IActionResult> Get()
    {
        var bills = await UserManagement.GetBills();
        return Ok(bills);
    }
    [HttpGet("GetBillById/{id}")]
    public async Task<IActionResult> Get(string id)
    {
        var bill = await UserManagement.GetBillById(id);
        if (bill == null) return NotFound();
        return Ok(bill);
    }
    [HttpPost("CreateBill")]
    public async Task<IActionResult> Create(BillRequestDto billRequestDto)
    {
        return Ok(await UserManagement.CreateBill(billRequestDto));
    }
}

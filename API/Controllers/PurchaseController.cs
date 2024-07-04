using BusinessObjects.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly JssatsContext _context;

        public PurchaseController(JssatsContext jssatsContext)
        {
            _context = jssatsContext;
        }


        ///// <summary>
        ///// Tạo mới một đơn mua h àng lại của khách hàng
        ///// </summary>
        //[HttpPost("CreatePurchase")]
        //public async Task<IActionResult> CreatePurchase(Purchase purchase)
        //{
        //    _context.Purchases.Add(purchase);
        //    await _context.SaveChangesAsync();
        //    return Ok(purchase);
        //}
    }
}

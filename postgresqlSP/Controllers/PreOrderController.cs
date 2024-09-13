using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Postgresql_API.Data; // 引用 DbContext 的命名空間
using Postgresql_API.Models; // 引用模型的命名空間

namespace Postgresql_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PreOrderController : ControllerBase
    {
        private readonly MyDbContext _context;

        public PreOrderController(MyDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePreOrder([FromBody] PreOrder preOrder)
        {
            if (preOrder == null)
            {
                return BadRequest("PreOrder data is null.");
            }

            try
            {
                _context.PreOrders.Add(preOrder);
                await _context.SaveChangesAsync();

                return Ok("Pre-order created successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}

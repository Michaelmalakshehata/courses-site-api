using courses_site_api.Extensions.models;
using courses_site_api.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace courses_site_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class reservedController : ControllerBase
    {
        private readonly courses_entitiy _context;

        public reservedController(courses_entitiy context)
        {
            _context = context;
        }
       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<reservedcourse>>> Getpurchased()
        {
            return await _context.Reservedcourses.ToListAsync();
             
        }

        [HttpPost]
        public async Task<ActionResult<string>> PostPurchasedcourses(reservedcourse reserve)
        {
            _context.Reservedcourses.Add(reserve);
            await _context.SaveChangesAsync();

            return Ok("تم أرسال طلب تفعيل الدوره بنجاح");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<string>> DeleteCourses_category(int id)
        {
            var item = _context.Reservedcourses.FirstOrDefault(i => i.id == id);
            if (item == null)
            {
                return "العنصر غير موجود";
            }
            else
            {
                _context.Reservedcourses.Remove(item);
                await _context.SaveChangesAsync();
                return Ok("تم المسح بنجاح");
            }
        }
    }
}

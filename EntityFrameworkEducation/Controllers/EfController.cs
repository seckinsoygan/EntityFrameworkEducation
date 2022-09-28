using EntityFrameworkEducation.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkEducation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EfController : ControllerBase
    {
        DenemeContext _context = new();

        [HttpGet("[action]")]
        public IActionResult GetList()
        {
            var result = _context.SimpleTables.ToList();
            return Ok(result);
        }
        [HttpPost("[action]")]
        public IActionResult Add(SimpleTable simpleTable)
        {
            _context.SimpleTables.Add(simpleTable);
            _context.SaveChanges();

            return Ok("Kayıt işlemi başarıyla tamamlandı.");
        }

        [HttpPost("[action]")]
        public IActionResult Update(SimpleTable simpleTable)
        {
            _context.SimpleTables.Update(simpleTable);
            _context.SaveChanges();

            return Ok("Güncelleme işlemi başarıyla tamamlandı.");
        }
        [HttpPost("[action]")]
        public IActionResult Remove(SimpleTable simpleTable)
        {
            _context.SimpleTables.Remove(simpleTable);
            _context.SaveChanges();

            return Ok("Silme işlemi başarıyla tamamlandı.");
        }
        [HttpPost("[action]")]

        //Birden fazla veri silmek için Ramove Range kullanılır.
        public IActionResult RemoveRange(SimpleTable[] simpleTables)
        {
            _context.SimpleTables.RemoveRange(simpleTables);
            _context.SaveChanges();

            return Ok("Silme işlemi başarıyla tamamlandı.");
        }
    }
}

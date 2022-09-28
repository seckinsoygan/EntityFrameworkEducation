using EntityFrameworkEducation.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkEducation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EfSorgulari : ControllerBase
    {
        DenemeContext _context = new();

        [HttpGet("[action]")]
        public IActionResult GetList()
        {
            //List,IList,IEnumarable,IQueryable
            //List<string> liste = new List<string>();
            //liste.Add("deneme");

            //Interface newlenemez
            //var result = _context.SimpleTables.ToList();

            IQueryable<SimpleTable> result = _context.SimpleTables.AsQueryable();
            result.Where(p => p.Id == 1 && p.Name.Contains("Seckin") || p.Id == 2);

            IEnumerable<SimpleTable> result2 = _context.SimpleTables.ToList();
            result2.Where(p => p.Id == 1);

            List<SimpleTable> result3 = _context.SimpleTables.ToList();
            result3.Where(p => p.Id == 1);

            var result4 = _context.SimpleTables.ToList().Where(p => p.Id == 1).FirstOrDefault();  //Listeler
            var result5 = _context.SimpleTables.ToList().Where(p => p.Id == 1).SingleOrDefault();  //Karşılayan birden fazla veri varsa hata verir.


            return Ok();

        }
    }
}

using EFCodeFirstEducation.Model;
using Microsoft.AspNetCore.Mvc;

namespace EFCodeFirstEducation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        Deneme2Context _context = new Deneme2Context();

        [HttpGet("[action]")]
        public IActionResult GetList()
        {
            var result = _context.Seckins.ToList();
            return Ok(result);
        }
    }
}

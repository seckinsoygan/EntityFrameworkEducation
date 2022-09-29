using EntityFrameworkEducation.Dtos;
using EntityFrameworkEducation.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkEducation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EfSorgularıController : ControllerBase
    {
        DenemeContext _context = new DenemeContext();

        [HttpGet("[action]")]
        public IActionResult GetList()
        {
            //var result = _context.Products.AsQueryable(); 

            var result = from Product in _context.Products
                         join
                         Category in _context.Categories on Product.CategoryId
                         equals Category.Id
                         select new ProductDto
                         {
                             Id = Product.Id,
                             CategoryId = Product.CategoryId,
                             CategoryName = Category.Name,
                             Name = Product.Name,
                             Price = Product.Price,
                         };



            return Ok(result.AsQueryable());
        }
    }
}

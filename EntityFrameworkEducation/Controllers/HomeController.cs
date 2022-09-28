using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace EntityFrameworkEducation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=Database1;Integrated Security=true");

        [HttpGet("Action")]
        public IActionResult GetList()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from SimpleTables", connection);
            DataTable datatable = new();
            datatable.Clear();
            adapter.Fill(datatable);

            var result = Newtonsoft.Json.JsonConvert.SerializeObject(datatable);

            return Ok(result);
        }



    }
}

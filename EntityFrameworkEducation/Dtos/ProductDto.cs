using EntityFrameworkEducation.Models;

namespace EntityFrameworkEducation.Dtos
{
    //DTO = Data Transfer Object :Genellikle Joinler için kullanıyoruz. 
    public class ProductDto : Product
    {
        public string CategoryName { get; set; }

    }
}

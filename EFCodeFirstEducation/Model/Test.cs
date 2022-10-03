using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstEducation.Model
{
    public class Test
    {
        //data annatations
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Name Alanı Zorunludur!")]
        public string Name { get; set; }

        [MaxLength(100, ErrorMessage = "Yaş en fazla 100 olabilir")]
        [Required(ErrorMessage = "Age Alanı Zorunludur!")]
        public int Age { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Telefon Alanı Zorunludur!")]
        public string Tel { get; set; }
    }
}

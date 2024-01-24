using System.ComponentModel.DataAnnotations;

namespace BlogWebApp.Models
{
    public class EmpLogin
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? PassCode { get; set; }
    }
}

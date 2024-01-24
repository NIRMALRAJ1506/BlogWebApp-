using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogWebAPI.Models
{
    [Table("EmpInfo")]
    public class EmpInfo
    {
        [Key]
        [Required(ErrorMessage = "The Email field is required.")]
        public string? EmailId { get; set; }
        [Required(ErrorMessage = "The Name field is required.")]
        public string? Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        [Required(ErrorMessage = "The PassCode field is required.")]
        public string? PassCode { get; set; }
    }
}

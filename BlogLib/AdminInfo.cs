using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogLib
{
    [Table("AdminInfo")]
    public class AdminInfo
    {
        [Key]
        public string? EmailId { get; set; }
        public string? Password { get; set; }
    }
}
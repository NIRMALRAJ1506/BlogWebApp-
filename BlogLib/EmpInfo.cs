using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLib
{
    [Table("EmpInfo")]
    public class EmpInfo
    {
        [Key]
        public string? EmailId { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string? PassCode { get; set; }
    }
}

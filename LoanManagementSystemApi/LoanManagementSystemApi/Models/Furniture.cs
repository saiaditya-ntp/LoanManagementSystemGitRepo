using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagementSystemApi.Models
{
    public class Furniture
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(2)]
        [Range(18,59)]
        public int Age { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public double ContactNumber { get; set; }
    }
}

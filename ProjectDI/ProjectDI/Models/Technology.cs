using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDI.Models
{
    public class Technology
    {
        [Key]
        public int TID { get; set; }
        [Required]
        public string TechnologyName { get; set; }
    }
}

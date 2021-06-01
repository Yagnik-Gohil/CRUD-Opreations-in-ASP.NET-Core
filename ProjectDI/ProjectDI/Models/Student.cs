using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDI.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Mobile { get; set; }
        [Required]
        public int TID { get; set; }
        
        [NotMapped]
        public string TechnologyName { get; set; }
    }
}

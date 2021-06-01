using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class Technology
    {
        [Key]
        public int TID { get; set; }
        [Required]
        public string TechnologyName { get; set; }
    }
}

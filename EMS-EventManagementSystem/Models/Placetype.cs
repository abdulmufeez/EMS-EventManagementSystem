using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_EventManagementSystem.Models
{
    public class Placetype
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Please enter correct name")]
        [Display(Name = "Place Type")]
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}

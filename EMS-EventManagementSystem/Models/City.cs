using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_EventManagementSystem.Models
{
    public class City
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "City")]
        public string Name { get; set; }

        public Country Country { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
}

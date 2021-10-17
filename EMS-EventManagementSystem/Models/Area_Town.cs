using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_EventManagementSystem.Models
{
    public class Area_Town
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Area")]
        public string Name { get; set; }

        [Required]
        public string Street { get; set; }

        public int PostalCode { get; set; }

        public City City { get; set; }

        [Required]
        public int CityId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_EventManagementSystem.Models
{
    public class Place
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public Area_Town Area_Town { get; set; }
        [Required]
        [Display(Name = "Area")]
        public int Area_TownId { get; set; }

        public Placetype Placetype { get; set; }
        [Required]
        [Display(Name = "Placetype")]
        public int PlacetypeId { get; set; }
    }
}

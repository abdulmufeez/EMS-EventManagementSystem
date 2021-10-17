using EMS_EventManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_EventManagementSystem.ViewModels
{
    public class PlaceCardListViewModel
    {
        public IEnumerable<Place> Places { get; set; }
        public Placetype Placetype { get; set; }
        
    }
}

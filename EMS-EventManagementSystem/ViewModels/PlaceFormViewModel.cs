using EMS_EventManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_EventManagementSystem.ViewModels
{
    public class PlaceFormViewModel
    {
        public Place Place { get; set; }
        public IEnumerable<Placetype> Placetype { get; set; }
        
    }
}

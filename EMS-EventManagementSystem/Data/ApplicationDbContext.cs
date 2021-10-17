using EMS_EventManagementSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS_EventManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Placetype> Placetypes { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Area_Town> Area_Towns { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

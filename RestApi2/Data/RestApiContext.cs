using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static RestApi2.Vehicle;
using static RestApi2.Ticket;

namespace RestApi2.Data
{
    public class RestApiContext : DbContext
    {
        public RestApiContext(DbContextOptions options): base(options) {
            
        }

        public DbSet<Login> Logins { get; set; }
        public DbSet<Park> Parks { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VehicleEntityConfiguration());
            modelBuilder.ApplyConfiguration(new TicketEntityConfiguration());
        }


    }
   

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;




namespace RestApi2
{
    public class Ticket
    {
        public int Id { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        public DateTime TimeIn { get; set; } //Giriş zamanı için kullanılır.

        public DateTime TimeOut { get; set; } //Çıkış zamanı için kullanılır.

        public double Cost { get; set; }
        public int TicketOfVehicleId { get; set; }


        public Ticket()
        {

        }
        public Ticket(Vehicle vehicle, DateTime TimeIn)
        {
            this.Vehicle = vehicle;
            this.TimeIn = TimeIn;
        }
        public class TicketEntityConfiguration : IEntityTypeConfiguration<Ticket>
        {
            public void Configure(EntityTypeBuilder<Ticket> builder)
            {

                builder.HasOne<Vehicle>(s => s.Vehicle)
                 .WithOne(ad => ad.Ticket)
                 .HasForeignKey<Ticket>(ad => ad.TicketOfVehicleId);


            }
        }

    }
}

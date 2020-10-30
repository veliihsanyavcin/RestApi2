using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System.Data.Entity.ModelConfiguration;

namespace RestApi2.Models
{
    //public class TicketConfigurations : EntityTypeConfiguration<Ticket>
    //{
    //    public TicketConfigurations()
    //    {
    //        this.Property(s => s.StudentName)
    //            .IsRequired()
    //            .HasMaxLength(50);

    //        this.Property(s => s.StudentName)
    //            .IsConcurrencyToken();

    //        // Configure a one-to-one relationship between Student & StudentAddress
    //        this.HasOptional(s => s.Address) // Mark Student.Address property optional (nullable)
    //            .WithRequired(ad => ad.Student); // Mark StudentAddress.Student property as required (NotNull).
    //    }
    //}
}

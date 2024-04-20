using eAppointmentServer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAppointmentServer.Infrastructure.Configurations;

internal sealed class PatientConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.Property(p => p.FirstName).HasColumnName("varchar(50)");
        builder.Property(p => p.LastName).HasColumnName("varchar(50)");
        builder.Property(p => p.City).HasColumnName("varchar(50)");
        builder.Property(p => p.Town).HasColumnName("varchar(50)");
        builder.Property(p => p.FullAddress).HasColumnName("varchar(400)");
        builder.Property(p => p.IdentityNumber).HasColumnName("varchar(11)");
        builder.HasIndex(x => x.IdentityNumber).IsUnique();
    }
}

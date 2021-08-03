﻿
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalShelter.Configurations
{

    public class TreatmentsEfConfiguration : IEntityTypeConfiguration<Treatment>
    {
        public void Configure(EntityTypeBuilder<Treatment> builder)
        {
            builder.HasKey(e => e.Id).HasName("Treatment_PK");
            builder.Property(e => e.Name).HasMaxLength(255).IsRequired();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using EmptyProject.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmptyProject.Database.Configuration
{
    public class BaseModelTypeConfiguration : IEntityTypeConfiguration<BaseModel>
    {
        public void Configure(EntityTypeBuilder<BaseModel> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Created)
                .ValueGeneratedOnAdd();
            builder.Property(b => b.Updated)
                .ValueGeneratedOnAddOrUpdate();
        }
    }
}

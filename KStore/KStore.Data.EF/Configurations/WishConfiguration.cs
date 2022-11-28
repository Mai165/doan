using KStore.Data.EF.Extensions;
using KStore.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KStore.Data.EF.Configurations
{
    class WishConfiguration : DbEntityConfiguration<Wish>
    {
        public override void Configure(EntityTypeBuilder<Wish> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}

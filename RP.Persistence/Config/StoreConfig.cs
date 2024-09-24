using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace RP.Persistence.Config
{
    public class StoreConfig
    {
        public StoreConfig(EntityTypeBuilder<Store> entityType)
        {
            entityType.Property(x => x.Name).IsRequired().HasMaxLength(100);
            entityType.Property(x => x.Description).IsRequired().HasMaxLength(600);
            entityType.Property(x => x.Cover).IsRequired().HasMaxLength(500);
            entityType.Property(x => x.Location).IsRequired().HasMaxLength(200);
            entityType.Property(x => x.Schedule).IsRequired().HasMaxLength(200);
        }
    }
}

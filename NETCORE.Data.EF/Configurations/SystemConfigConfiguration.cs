using NETCORE.Data.EF.Extentions;
using NETCORE.Data.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCORE.Data.EF.Configruations
{
    class SystemConfigConfiguration : DbEntityConfiguration<Config>
    {
        public override void Configure(EntityTypeBuilder<Config> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}

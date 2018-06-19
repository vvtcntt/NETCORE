using NETCORE.Data.EF.Extentions;
using NETCORE.Data.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace NETCORE.Data.EF.Configruations
{
    class AnnouncementConfiguration : DbEntityConfiguration<Announcement>
    {
        public override void Configure(EntityTypeBuilder<Announcement> entity)
        {
            entity.Property(p => p.Id).HasMaxLength(128)
                .IsRequired().HasColumnType("varchar(128)");
        }
    }
}

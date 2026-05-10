using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Domain.Entities.Media;

namespace Proyecto.Infrastructure.Configurations.Media
{
    public class WatchHistoryConfiguration : IEntityTypeConfiguration<WatchHistory>
    {
        public void Configure(EntityTypeBuilder<WatchHistory> builder)
        {
            builder.ToTable("WatchHistories");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User)
                .WithMany(x => x.WatchHistories)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Media)
                .WithMany(x => x.WatchHistories)
                .HasForeignKey(x => x.MediaId);

            builder.HasIndex(x => x.LastViewedAt);
        }
    }
}

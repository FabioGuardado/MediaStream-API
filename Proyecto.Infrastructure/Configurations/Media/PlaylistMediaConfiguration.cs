using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Domain.Entities.Media;

namespace Proyecto.Infrastructure.Configurations.Media
{
    public class PlaylistMediaConfiguration : IEntityTypeConfiguration<PlaylistMedia>
    {
        public void Configure(EntityTypeBuilder<PlaylistMedia> builder)
        {
            builder.ToTable("PlaylistMedia");

            builder.HasKey(x => new
            {
                x.PlaylistId,
                x.MediaId
            });

            builder.HasOne(x => x.Playlist)
                .WithMany(x => x.PlaylistItems)
                .HasForeignKey(x => x.PlaylistId);

            builder.HasOne(x => x.Media)
                .WithMany(x => x.PlaylistItems)
                .HasForeignKey(x => x.MediaId);
        }
    }
}

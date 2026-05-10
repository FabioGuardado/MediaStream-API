using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Domain.Entities.Media;

namespace Proyecto.Infrastructure.Configurations.Media
{
    public class FavoriteConfiguration : IEntityTypeConfiguration<Favorite>
    {
        public void Configure(EntityTypeBuilder<Favorite> builder)
        {
            builder.ToTable("Favorites");

            builder.HasKey(x => new
            {
                x.UserId,
                x.MediaId
            });

            builder.HasOne(x => x.User)
                .WithMany(x => x.Favorites)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Media)
                .WithMany(x => x.Favorites)
                .HasForeignKey(x => x.MediaId);
        }
    }
}

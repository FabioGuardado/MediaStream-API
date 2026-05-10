using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proyecto.Domain.Entities.Media;

namespace Proyecto.Infrastructure.Configurations.Media
{
    public class MediaConfiguration : IEntityTypeConfiguration<MediaItem>
    {
        public void Configure(EntityTypeBuilder<MediaItem> builder)
        {
            builder.ToTable("Media");

            builder.HasKey(x => x.Id);

            // TPH
            builder.HasDiscriminator<string>("Discriminator")
                .HasValue<Video>("Video")
                .HasValue<Audio>("Audio");

            builder.Property(x => x.Title)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.FileName)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.StoredFileName)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.FilePath)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(x => x.ThumbnailPath)
                .HasMaxLength(500);

            builder.Property(x => x.MimeType)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasIndex(x => x.Title);

            builder.HasIndex(x => x.MediaType);

            builder.HasIndex(x => x.CreatedAt);

            builder.HasOne(x => x.UploadedByUser)
                .WithMany(x => x.UploadedMedia)
                .HasForeignKey(x => x.UploadedByUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.MediaItems)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Proyecto.Domain.Common;
using Proyecto.Domain.Entities.Enums;
using Proyecto.Domain.Entities.Identity;

namespace Proyecto.Domain.Entities.Media
{
    public abstract class MediaItem : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string FileName { get; set; } = string.Empty;

        public string StoredFileName { get; set; } = string.Empty;

        public string FilePath { get; set; } = string.Empty;

        public string? ThumbnailPath { get; set; }

        public int DurationSeconds { get; set; }

        public long FileSizeBytes { get; set; }

        public string MimeType { get; set; } = string.Empty;

        public long Views { get; set; }

        public bool IsPublic { get; set; } = true;

        public bool IsDeleted { get; set; } = false;

        public MediaType MediaType { get; set; }

        public string UploadedByUserId { get; set; } = string.Empty;

        public AppUser UploadedByUser { get; set; } = null!;

        public Guid CategoryId { get; set; }

        public Category Category { get; set; } = null!;

        public ICollection<PlaylistMedia> PlaylistItems { get; set; }
            = new List<PlaylistMedia>();

        public ICollection<Favorite> Favorites { get; set; }
            = new List<Favorite>();

        public ICollection<WatchHistory> WatchHistories { get; set; }
            = new List<WatchHistory>();
    }
}

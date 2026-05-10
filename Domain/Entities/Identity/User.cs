using System;
using System.Collections.Generic;
using System.Text;
using Proyecto.Domain.Common;
using Proyecto.Domain.Entities.Media;

namespace Proyecto.Domain.Entities.Identity
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string Username { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public string? ProfileImageUrl { get; set; }

        public DateTime? LastLoginAt { get; set; }

        public bool IsActive { get; set; } = true;

        public Guid RoleId { get; set; }

        public Role Role { get; set; } = null!;

        public ICollection<MediaItem> UploadedMedia { get; set; }
            = new List<MediaItem>();

        public ICollection<Playlist> Playlists { get; set; }
            = new List<Playlist>();

        public ICollection<Favorite> Favorites { get; set; }
            = new List<Favorite>();

        public ICollection<WatchHistory> WatchHistories { get; set; }
            = new List<WatchHistory>();

        public ICollection<RefreshToken> RefreshTokens { get; set; }
            = new List<RefreshToken>();
    }
}

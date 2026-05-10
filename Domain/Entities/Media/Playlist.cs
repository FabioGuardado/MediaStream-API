using System;
using System.Collections.Generic;
using System.Text;
using Proyecto.Domain.Common;
using Proyecto.Domain.Entities.Identity;

namespace Proyecto.Domain.Entities.Media
{
    public class Playlist : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public Guid UserId { get; set; }

        public User User { get; set; } = null!;

        public ICollection<PlaylistMedia> PlaylistItems { get; set; }
            = new List<PlaylistMedia>();
    }
}

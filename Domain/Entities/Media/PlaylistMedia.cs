using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Domain.Entities.Media
{
    public class PlaylistMedia
    {
        public Guid PlaylistId { get; set; }

        public Playlist Playlist { get; set; } = null!;

        public Guid MediaId { get; set; }

        public MediaItem Media { get; set; } = null!;

        public int OrderIndex { get; set; }

        public DateTime AddedAt { get; set; } = DateTime.UtcNow;
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Proyecto.Domain.Common;
using Proyecto.Domain.Entities.Identity;

namespace Proyecto.Domain.Entities.Media
{
    public class WatchHistory : BaseEntity
    {
        public string UserId { get; set; } = string.Empty;

        public AppUser User { get; set; } = null!;

        public Guid MediaId { get; set; }

        public MediaItem Media { get; set; } = null!;

        public int CurrentSecond { get; set; }

        public bool Completed { get; set; }

        public DateTime LastViewedAt { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Proyecto.Domain.Entities.Identity;

namespace Proyecto.Domain.Entities.Media
{
    public class Favorite
    {
        public Guid UserId { get; set; }

        public User User { get; set; } = null!;

        public Guid MediaId { get; set; }

        public MediaItem Media { get; set; } = null!;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

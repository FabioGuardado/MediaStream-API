using System;
using System.Collections.Generic;
using System.Text;
using Proyecto.Domain.Common;

namespace Proyecto.Domain.Entities.Media
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public ICollection<MediaItem> MediaItems { get; set; }
            = new List<MediaItem>();
    }
}

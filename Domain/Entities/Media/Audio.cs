using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Domain.Entities.Media
{
    public class Audio : MediaItem
    {
        public string? Artist { get; set; }

        public string? Album { get; set; }

        public string? Genre { get; set; }

        public int Bitrate { get; set; }
    }
}

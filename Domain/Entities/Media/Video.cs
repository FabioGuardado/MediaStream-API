using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Domain.Entities.Media
{
    public  class Video : MediaItem
    {
        public string? Resolution { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public decimal FrameRate { get; set; }
    }
}

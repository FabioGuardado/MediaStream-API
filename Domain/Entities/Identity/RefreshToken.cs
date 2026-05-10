using System;
using System.Collections.Generic;
using System.Text;
using Proyecto.Domain.Common;

namespace Proyecto.Domain.Entities.Identity
{
    public class RefreshToken : BaseEntity
    {
        public string Token { get; set; } = string.Empty;

        public DateTime ExpiresAt { get; set; }

        public DateTime? RevokedAt { get; set; }

        public string UserId { get; set; } = string.Empty;

        public AppUser User { get; set; } = null!;
    }
}

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

        public Guid UserId { get; set; }

        public User User { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Proyecto.Domain.Common;

namespace Proyecto.Domain.Entities.Identity
{
    public class Role : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public ICollection<User> Users { get; set; } = new List<User>();
    }
}

﻿using Spiderly.Shared.Attributes.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiderly.Security.Entities
{
    public class RolePermission
    {
        [M2MMaintanceEntity(nameof(Role.Permissions))]
        public virtual Role Role { get; set; }

        [M2MEntity(nameof(Permission.Roles))]
        public virtual Permission Permission { get; set; }
    }
}

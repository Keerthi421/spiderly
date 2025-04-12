﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiderly.Shared.Attributes.EF
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class UIAdditionalPermissionCodeForUpdateAttribute : Attribute
    {
        public UIAdditionalPermissionCodeForUpdateAttribute(string permissionCode)
        {
            
        }
    }
}

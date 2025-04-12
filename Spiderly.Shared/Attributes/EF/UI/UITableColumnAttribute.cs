﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiderly.Shared.Attributes.EF.UI
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class UITableColumnAttribute : Attribute
    {
        public UITableColumnAttribute(string field, string translateKey = null) { }
    }
}

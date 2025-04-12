﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiderly.Security.Enums
{
    public static partial class SecurityPermissionCodes
    {
        public static string ReadUserExtended { get; } = "ReadUserExtended";
        public static string EditUserExtended { get; } = "EditUserExtended";
        public static string InsertUserExtended { get; } = "InsertUserExtended";
        public static string DeleteUserExtended { get; } = "DeleteUserExtended";
    }
}

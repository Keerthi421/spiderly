﻿using Spiderly.Shared.Attributes;
using Spiderly.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiderly.Security.DTO
{
    [CustomValidator("RuleFor(x => x.Email).NotEmpty().Length(5, 100).EmailAddress();")]
    //[CustomValidator("RuleFor(x => x.Password).NotEmpty().Length(6, 20);")]
    public partial class RegistrationDTO
    {
        public string Email { get; set; }
        //public string Password { get; set; }
        public string BrowserId { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class PlatformRegistration
    {
        [Required]
        public string name { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string email { get; set; } = string.Empty;
        [Required]
        public Guid role_id { get; set; }


        [Required]
        [RegularExpression(@"^\+\d{1,3}\d{9}$", ErrorMessage = "Contact number must start with a '+' sign, followed by the country code (1-3 digits), and then 9 digits")]

        public string contact { get; set; } = string.Empty;
    }
}

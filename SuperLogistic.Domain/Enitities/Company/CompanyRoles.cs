﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLogistic.Domain.Enitities.Company
{
    public class CompanyRoles
    {
        [Key]
        [Required]
        public Guid role_id { get; set; }
        [Required]

        public string role_name { get; set; } = string.Empty;
    }
}

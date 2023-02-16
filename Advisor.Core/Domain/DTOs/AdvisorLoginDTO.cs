﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advisor.Core.Domain.DTOs
{
    public class AdvisorLoginDTO
    {
        [Required, EmailAddress]
        public string Email { get; set; }=string.Empty;
        [Required]
        public string Password { get; set; }= string.Empty;
    }
}

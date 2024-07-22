﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.DTO
{
    public class SessionContext
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int? CounterId { get; set; }
        public string? Code { get; set; }
        public string? FullName { get; set; }
        public string? Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public bool Status { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Star.Models
{
    public partial class Account
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public bool? StatusAccount { get; set; }
        public short? RoleAccount { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}

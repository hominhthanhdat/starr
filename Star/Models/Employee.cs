using System;
using System.Collections.Generic;

namespace Star.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Contracts = new HashSet<Contract>();
        }

        public int EmployeeId { get; set; }
        public string? FullName { get; set; }
        public string? AddressEmployee { get; set; }
        public string? PhoneNumber { get; set; }
        public string? QualityEducation { get; set; }
        public string? RoleEmployee { get; set; }
        public string? Achievement { get; set; }
        public string? PhotoEmployee { get; set; }
        public short? StatusEmployee { get; set; }
        public int? DepartmentId { get; set; }
        public int? BusinessId { get; set; }
        public string? Grade { get; set; }

        public virtual Business? Business { get; set; }
        public virtual Department? Department { get; set; }
        public virtual Account Account { get; set; } = null!;
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}

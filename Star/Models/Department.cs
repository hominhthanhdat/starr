using System;
using System.Collections.Generic;

namespace Star.Models
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DepartmentId { get; set; }
        public string? NameDepartment { get; set; }
        public string? AddressDepartment { get; set; }
        public bool? StatusDepartment { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Star.Models
{
    public partial class Business
    {
        public Business()
        {
            Careers = new HashSet<Career>();
            Contracts = new HashSet<Contract>();
            Employees = new HashSet<Employee>();
            Requests = new HashSet<Request>();
        }

        public int BusinessId { get; set; }
        public string? NameBusiness { get; set; }
        public string? DescriptionBusiness { get; set; }
        public string? Duration { get; set; }
        public string? PhotoBusiness { get; set; }
        public bool? StatusBusiness { get; set; }
        public int? CategoryId { get; set; }

        public virtual CategoryBusiness? Category { get; set; }
        public virtual ICollection<Career> Careers { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
    }
}

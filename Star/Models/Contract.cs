using System;
using System.Collections.Generic;

namespace Star.Models
{
    public partial class Contract
    {
        public int ContractId { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public short? StatusContract { get; set; }
        public int? ClientId { get; set; }
        public int? EmployeeId { get; set; }
        public int? BusinessId { get; set; }

        public virtual Business? Business { get; set; }
        public virtual Client? Client { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}

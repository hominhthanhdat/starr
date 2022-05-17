using System;
using System.Collections.Generic;

namespace Star.Models
{
    public partial class Career
    {
        public Career()
        {
            Candidates = new HashSet<Candidate>();
        }

        public int CareerId { get; set; }
        public string? Offer { get; set; }
        public string? DescriptionCareer { get; set; }
        public string? Salary { get; set; }
        public string? Requirement { get; set; }
        public string? Location { get; set; }
        public string? Title { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? StatusCareer { get; set; }
        public int? BusinessId { get; set; }

        public virtual Business? Business { get; set; }
        public virtual ICollection<Candidate> Candidates { get; set; }
    }
}

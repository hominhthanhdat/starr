using System;
using System.Collections.Generic;

namespace Star.Models
{
    public partial class Candidate
    {
        public int CandidateId { get; set; }
        public string? FullNameCandidate { get; set; }
        public string? AddressCandidate { get; set; }
        public string? PhoneNumber { get; set; }
        public string? QualityEducation { get; set; }
        public bool? StatusCandidate { get; set; }
        public int? CareerId { get; set; }

        public virtual Career? Career { get; set; }
    }
}

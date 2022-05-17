using System;
using System.Collections.Generic;

namespace Star.Models
{
    public partial class Testimonial
    {
        public int TestmonialId { get; set; }
        public string? Photo { get; set; }
        public string? Content { get; set; }
        public string? Author { get; set; }
    }
}

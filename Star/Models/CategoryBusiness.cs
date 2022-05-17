using System;
using System.Collections.Generic;

namespace Star.Models
{
    public partial class CategoryBusiness
    {
        public CategoryBusiness()
        {
            Businesses = new HashSet<Business>();
        }

        public int CategoryId { get; set; }
        public string? NameCategory { get; set; }
        public string? DescriptionCategory { get; set; }
        public bool? StatusCategory { get; set; }

        public virtual ICollection<Business> Businesses { get; set; }
    }
}

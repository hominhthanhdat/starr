using System;
using System.Collections.Generic;

namespace Star.Models
{
    public partial class Request
    {
        public int RequestId { get; set; }
        public string? IdentifyClient { get; set; }
        public short? StatusRequest { get; set; }
        public string? NameClient { get; set; }
        public string? AddressClient { get; set; }
        public string? EmailClient { get; set; }
        public string? PhoneClient { get; set; }
        public int? BusinessId { get; set; }

        public virtual Business? Business { get; set; }
    }
}

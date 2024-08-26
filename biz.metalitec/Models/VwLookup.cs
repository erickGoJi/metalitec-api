using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwLookup
    {
        public string LookupName { get; set; }
        public int? LookupId { get; set; }
        public string LookupValue { get; set; }
        public int? System { get; set; }
    }
}

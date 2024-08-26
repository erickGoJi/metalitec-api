using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class LookupValue
    {
        public int LookupValueId { get; set; }
        public int? LookupValueKey { get; set; }
        public int LookupId { get; set; }
        public string Name { get; set; }
        public byte Default { get; set; }
        public byte? System { get; set; }
        public byte? RnU { get; set; }

        public virtual Lookup Lookup { get; set; }
    }
}

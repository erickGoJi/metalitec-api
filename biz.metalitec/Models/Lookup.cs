using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Lookup
    {
        public Lookup()
        {
            LookupValues = new HashSet<LookupValue>();
        }

        public int LookupId { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public int System { get; set; }

        public virtual ICollection<LookupValue> LookupValues { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class RollReference
    {
        public RollReference()
        {
            RollReferenceItems = new HashSet<RollReferenceItem>();
            RollReferenceLines = new HashSet<RollReferenceLine>();
        }

        public int RollReferenceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SupplierId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? Version { get; set; }

        public virtual ICollection<RollReferenceItem> RollReferenceItems { get; set; }
        public virtual ICollection<RollReferenceLine> RollReferenceLines { get; set; }
    }
}

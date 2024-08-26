using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SplitMarkItem
    {
        public int SplitMarkItemId { get; set; }
        public int FromMarkItemId { get; set; }
        public int MarkItemId { get; set; }
        public int? PhaseId { get; set; }

        public virtual ContractMarkItem FromMarkItem { get; set; }
    }
}

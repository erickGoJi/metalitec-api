using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ExtraGroupExtra
    {
        public int ExtraGroupId { get; set; }
        public int ExtraId { get; set; }
        public int? Rank { get; set; }

        public virtual Extra Extra { get; set; }
        public virtual ExtraGroup ExtraGroup { get; set; }
    }
}

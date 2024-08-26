using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemUsageItem
    {
        public int ItemUsageId { get; set; }
        public int ItemId { get; set; }

        public virtual Item Item { get; set; }
        public virtual ItemUsage ItemUsage { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class CombinedMarkItem
    {
        public int CombinedMarkItemId { get; set; }
        public int ContractMarkItemId { get; set; }
        public int ContractMarkItemInstanceId { get; set; }

        public virtual ContractMarkItem ContractMarkItem { get; set; }
    }
}

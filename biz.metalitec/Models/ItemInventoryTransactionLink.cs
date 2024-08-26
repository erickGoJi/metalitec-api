using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemInventoryTransactionLink
    {
        public int TransActionLineIdOut { get; set; }
        public int TransActionLineIdIn { get; set; }

        public virtual ItemInventoryTransactionLine TransActionLineIdInNavigation { get; set; }
        public virtual ItemInventoryTransactionLine TransActionLineIdOutNavigation { get; set; }
    }
}

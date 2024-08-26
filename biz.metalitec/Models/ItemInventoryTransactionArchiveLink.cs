using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemInventoryTransactionArchiveLink
    {
        public int ContractId { get; set; }
        public int TransactionId { get; set; }
        public bool FullyArchived { get; set; }
    }
}

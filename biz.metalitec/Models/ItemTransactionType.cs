using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemTransactionType
    {
        public ItemTransactionType()
        {
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            ItemInventoryTransactions = new HashSet<ItemInventoryTransaction>();
        }

        public int ItemTransactionTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public byte? System { get; set; }

        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<ItemInventoryTransaction> ItemInventoryTransactions { get; set; }
    }
}

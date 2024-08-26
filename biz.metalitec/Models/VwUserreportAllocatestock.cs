using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportAllocatestock
    {
        public int AllocateStockId { get; set; }
        public string InventoryAllocation { get; set; }
        public string InventoryAllocationDescription { get; set; }
        public DateTime InventoryAllocationDate { get; set; }
        public byte Complete { get; set; }
        public int? ContractId { get; set; }
        public string Contract { get; set; }
        public string Phase { get; set; }
        public string InventoryAllocationNotes { get; set; }
    }
}

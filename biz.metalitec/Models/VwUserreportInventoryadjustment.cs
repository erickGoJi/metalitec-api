using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportInventoryadjustment
    {
        public int InventoryAdjustmentId { get; set; }
        public string InventoryAdjustment { get; set; }
        public string InventoryAdjustmentDescription { get; set; }
        public DateTime InventoryAdjustmentDate { get; set; }
        public byte Complete { get; set; }
        public int? SupplierId { get; set; }
        public string InventoryAdjustmentNotes { get; set; }
    }
}

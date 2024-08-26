using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemUsageFitting
    {
        public int ItemUsageFittingId { get; set; }
        public int ItemUsageId { get; set; }
        public int FittingItemTypeId { get; set; }
        public int LineItemId { get; set; }
        public int Quantity { get; set; }
        public string Notes { get; set; }
        public byte UnitTypeId { get; set; }
        public double PerUnitQty { get; set; }
        public double To { get; set; }

        public virtual ItemUsage ItemUsage { get; set; }
    }
}

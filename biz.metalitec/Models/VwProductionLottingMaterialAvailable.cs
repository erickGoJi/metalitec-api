using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwProductionLottingMaterialAvailable
    {
        public int LotId { get; set; }
        public DateTime? MaterialDueFromDate { get; set; }
        public DateTime? MaterialDueToDate { get; set; }
        public DateTime? MaterialAvailableFromDate { get; set; }
        public DateTime? MaterialAvailableToDate { get; set; }
        public bool? AllMaterialOrdered { get; set; }
        public bool? AllMaterialAvailable { get; set; }
        public DateTime? MarkItemsDueFromDate { get; set; }
        public DateTime? MarkItemsDueToDate { get; set; }
        public DateTime? MarkItemsAvailableFromDate { get; set; }
        public DateTime? MarkItemsAvailableToDate { get; set; }
        public bool? AllItemsIssued { get; set; }
        public bool? AllItemsComplete { get; set; }
    }
}

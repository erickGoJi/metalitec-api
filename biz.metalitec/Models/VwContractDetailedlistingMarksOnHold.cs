using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwContractDetailedlistingMarksOnHold
    {
        public int ContractListingId { get; set; }
        public int ContractDrawingId { get; set; }
        public int? MarkId { get; set; }
        public string Mark { get; set; }
        public bool? IsAssemblyMark { get; set; }
        public int? ContractItemId { get; set; }
        public string MarkItem { get; set; }
        public double Quantity { get; set; }
        public string ParentMark { get; set; }
    }
}

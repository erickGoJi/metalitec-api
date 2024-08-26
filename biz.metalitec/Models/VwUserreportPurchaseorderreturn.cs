using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportPurchaseorderreturn
    {
        public int PurchaseOrderReturnId { get; set; }
        public string PurchaseOrderReturn { get; set; }
        public DateTime PurchaseOrderReturnDate { get; set; }
        public string Reason { get; set; }
        public byte Complete { get; set; }
        public int? SupplierId { get; set; }
        public string Supplier { get; set; }
        public string ExternalReference { get; set; }
        public string PurchaseOrderReturnNotes { get; set; }
    }
}

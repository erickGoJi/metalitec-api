using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportEdiFabricator
    {
        public int EdifileId { get; set; }
        public int? SupplierId { get; set; }
        public string Supplier { get; set; }
        public string ListingType { get; set; }
        public string EdiBatchNumber { get; set; }
        public int FileNumber { get; set; }
        public string SupplierEMailAddress { get; set; }
        public int? PurchaseOrderId { get; set; }
        public string PurchaseOrder { get; set; }
        public DateTime? DateSent { get; set; }
        public string SentBy { get; set; }
        public DateTime? DateCancelled { get; set; }
        public string CancelledBy { get; set; }
        public DateTime? DateReceived { get; set; }
        public DateTime? DateProcessed { get; set; }
        public string ProcessedBy { get; set; }
    }
}

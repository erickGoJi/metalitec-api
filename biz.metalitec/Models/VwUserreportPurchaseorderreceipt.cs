using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportPurchaseorderreceipt
    {
        public int PurchaseOrderReceiptId { get; set; }
        public string PurchaseOrderReceipt { get; set; }
        public string PurchaseOrderReceiptDescription { get; set; }
        public DateTime PurchaseOrderReceiptDate { get; set; }
        public byte Complete { get; set; }
        public int? SupplierId { get; set; }
        public string Supplier { get; set; }
        public string SupplierDeliveryNote { get; set; }
        public string PurchaseOrderReceiptNotes { get; set; }
    }
}

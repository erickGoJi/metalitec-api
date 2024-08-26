using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwPurchaseOrderReceiptSearch
    {
        public int PurchaseOrderReceiptId { get; set; }
        public int? FacilityId { get; set; }
        public string Facility { get; set; }
        public int? SupplierId { get; set; }
        public string Supplier { get; set; }
        public string SupplierDeliveryNote { get; set; }
        public int ItemTransactionTypeId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public byte Complete { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}

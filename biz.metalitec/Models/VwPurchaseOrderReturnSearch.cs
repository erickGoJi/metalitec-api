using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwPurchaseOrderReturnSearch
    {
        public int PurchaseOrderReturnId { get; set; }
        public int? SupplierId { get; set; }
        public string Supplier { get; set; }
        public string SupplierReference { get; set; }
        public int ItemTransactionTypeId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public byte Complete { get; set; }
        public string Notes { get; set; }
    }
}

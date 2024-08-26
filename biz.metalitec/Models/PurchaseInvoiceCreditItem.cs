using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PurchaseInvoiceCreditItem
    {
        public int PurchaseInvoiceCreditItemId { get; set; }
        /// <summary>
        /// The Source PurchaseInvoiceCreditID
        /// </summary>
        public int PurchaseInvoiceCreditId { get; set; }
        /// <summary>
        /// The linked PurchaseInvoiceItemID
        /// </summary>
        public int PurchaseInvoiceItemId { get; set; }
        public double Ratio { get; set; }
        public double CreditValue { get; set; }
        public double CreditTaxValue { get; set; }

        public virtual PurchaseInvoiceCredit PurchaseInvoiceCredit { get; set; }
        public virtual PurchaseInvoiceItem PurchaseInvoiceItem { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PurchaseInvoiceCredit
    {
        public PurchaseInvoiceCredit()
        {
            PurchaseInvoiceCreditItems = new HashSet<PurchaseInvoiceCreditItem>();
        }

        public int PurchaseInvoiceCreditId { get; set; }
        /// <summary>
        /// The Source PurchaseInvoiceID
        /// </summary>
        public int PurchaseInvoiceId { get; set; }
        /// <summary>
        /// Credit Type - 5 = General Credit, 6 = Line Credit
        /// </summary>
        public int LineTypeId { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// Cost Code
        /// </summary>
        public int? CostCodeId { get; set; }
        public int? TaxCodeId { get; set; }
        /// <summary>
        /// Tax Percentage
        /// </summary>
        public double TaxPercent { get; set; }
        /// <summary>
        /// Tax Value in Supplier Currency
        /// </summary>
        public double OriginalTaxValue { get; set; }
        /// <summary>
        /// Tax Value in Facility Currency
        /// </summary>
        public double TaxValue { get; set; }
        /// <summary>
        /// Credit Value in Supplier Currency
        /// </summary>
        public double OriginalValue { get; set; }
        /// <summary>
        /// Credit Value in Facility Currency
        /// </summary>
        public double Value { get; set; }
        /// <summary>
        /// The Contract this Credit belongs to
        /// </summary>
        public int? ContractId { get; set; }
        /// <summary>
        /// Pro-rata application of this Credit - 1 = By Weight, 2 = By Value, 3 = By Quantity
        /// </summary>
        public int? ApplyById { get; set; }

        public virtual PurchaseInvoice PurchaseInvoice { get; set; }
        public virtual ICollection<PurchaseInvoiceCreditItem> PurchaseInvoiceCreditItems { get; set; }
    }
}

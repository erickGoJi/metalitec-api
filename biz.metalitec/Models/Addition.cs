using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Addition
    {
        public Addition()
        {
            PurchaseInvoiceItems = new HashSet<PurchaseInvoiceItem>();
        }

        public int AdditionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public double UnitPrice { get; set; }
        public DateTime ExchangeRateDate { get; set; }
        public double? ExchangeRate { get; set; }
        public bool WillAddToInventoryValue { get; set; }
        public double? TaxPercent { get; set; }
        public int ParentId { get; set; }
        /// <summary>
        /// ~~(53=Purchase Order Receipt, 122=Purchase Order Item, 152=Facility Transfer)
        /// </summary>
        public int ParentTypeId { get; set; }
        public int UnitId { get; set; }
        public int SupplierId { get; set; }
        public int? AddressId { get; set; }
        public int? TaxCodeId { get; set; }
        public int? PaymentTermsId { get; set; }
        public int CostCodeId { get; set; }
        public int CurrencyId { get; set; }
        /// <summary>
        /// The template used to create the Addition
        /// </summary>
        public int? AdditionTemplateId { get; set; }
        public int? Instance { get; set; }
        public int? ItemInventoryTrackingGuidId { get; set; }

        public virtual AdditionTemplate AdditionTemplate { get; set; }
        public virtual Address Address { get; set; }
        public virtual CostCode CostCode { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual ItemInventoryTrackingGuid ItemInventoryTrackingGuid { get; set; }
        public virtual PaymentTerm PaymentTerms { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual TaxCode TaxCode { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ICollection<PurchaseInvoiceItem> PurchaseInvoiceItems { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            AdditionTemplates = new HashSet<AdditionTemplate>();
            Additions = new HashSet<Addition>();
            Edifiles = new HashSet<Edifile>();
            ItemInventoryProperties = new HashSet<ItemInventoryProperty>();
            ItemInventoryTransactions = new HashSet<ItemInventoryTransaction>();
            ItemSuppliers = new HashSet<ItemSupplier>();
            PurchaseInvoices = new HashSet<PurchaseInvoice>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        /// <summary>
        /// Supplier Unique ID Number
        /// </summary>
        public int SupplierId { get; set; }
        /// <summary>
        /// Supplier name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Type of supplier
        /// </summary>
        public int? SupplierTypeId { get; set; }
        /// <summary>
        /// Default currency of supplier
        /// </summary>
        public int CurrencyId { get; set; }
        public string ExternalReference { get; set; }
        /// <summary>
        /// The default tax code to use for this supplier
        /// </summary>
        public int? TaxCodeId { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        public byte System { get; set; }
        /// <summary>
        /// Internal Key to Identity Suppliers required by the StruMIS System
        /// </summary>
        public byte SystemKey { get; set; }
        public int Version { get; set; }
        /// <summary>
        /// Unique ID for the payment term
        /// </summary>
        public int? PaymentTermsId { get; set; }
        public bool IsMill { get; set; }
        public bool IsTransport { get; set; }
        public int? EdifileFormat { get; set; }
        public string Edireference { get; set; }
        public string Ediemail { get; set; }
        public string EdisubjectHeaderSuffix { get; set; }
        public string RollRefReference { get; set; }
        public string RollRefEdiemail { get; set; }
        public int? RollReferenceInterface { get; set; }
        public string Poedireference { get; set; }
        public string Poediemail { get; set; }
        public int? PoediinterfaceOut { get; set; }
        public int? PoediinterfaceIn { get; set; }
        public string PoedireferenceReturn { get; set; }
        public string PoediemailReturn { get; set; }
        public int? FacilityId { get; set; }
        public bool? IsEstimateSupplier { get; set; }
        public int? EdiinterfaceIn { get; set; }
        public int? EdiinterfaceOut { get; set; }
        public string Notes { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual TransactionInterface EdiinterfaceInNavigation { get; set; }
        public virtual TransactionInterface EdiinterfaceOutNavigation { get; set; }
        public virtual Facility Facility { get; set; }
        public virtual PaymentTerm PaymentTerms { get; set; }
        public virtual TransactionInterface PoediinterfaceInNavigation { get; set; }
        public virtual TransactionInterface PoediinterfaceOutNavigation { get; set; }
        public virtual TransactionInterface RollReferenceInterfaceNavigation { get; set; }
        public virtual TaxCode TaxCode { get; set; }
        public virtual ICollection<AdditionTemplate> AdditionTemplates { get; set; }
        public virtual ICollection<Addition> Additions { get; set; }
        public virtual ICollection<Edifile> Edifiles { get; set; }
        public virtual ICollection<ItemInventoryProperty> ItemInventoryProperties { get; set; }
        public virtual ICollection<ItemInventoryTransaction> ItemInventoryTransactions { get; set; }
        public virtual ICollection<ItemSupplier> ItemSuppliers { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}

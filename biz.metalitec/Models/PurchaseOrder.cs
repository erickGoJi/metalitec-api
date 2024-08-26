using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            Edifiles = new HashSet<Edifile>();
            PurchaseOrderAuthorisations = new HashSet<PurchaseOrderAuthorisation>();
            PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
        }

        public int PurchaseOrderId { get; set; }
        /// <summary>
        /// Specify a name for the purchase order
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the purchase order
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The date of the purchase order
        /// </summary>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// ~The Supplier table foreign key
        /// </summary>
        public int SupplierId { get; set; }
        public int? SupplierAddressId { get; set; }
        /// <summary>
        /// The suppliers&apos; reference for this order
        /// </summary>
        public string SupplierReference { get; set; }
        public string RequisitionName { get; set; }
        /// <summary>
        /// The default delivery location for the order
        /// </summary>
        public int ItemLocationId { get; set; }
        public DateTime? OrderDeliveryDate { get; set; }
        public int? OrderCategory { get; set; }
        /// <summary>
        /// ~The Currency table foreign key
        /// </summary>
        public int CurrencyId { get; set; }
        /// <summary>
        /// The date to use to retrieve the exchange rate
        /// </summary>
        public DateTime? ExchangeRateDate { get; set; }
        /// <summary>
        /// ~The exchange rate if it is a foreign currency
        /// </summary>
        public double? ExchangeRate { get; set; }
        /// <summary>
        /// ~The status of the order - 1 Preparation, 2 - Released, 3 - Closed
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// The Payment terms agreed with the supplier for this order
        /// </summary>
        public int? PaymentTermsId { get; set; }
        public int? TaxCodeId { get; set; }
        public string Notes { get; set; }
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
        public int Version { get; set; }
        /// <summary>
        /// Exported to External System
        /// </summary>
        public bool Exported { get; set; }
        /// <summary>
        /// Who performed the Export
        /// </summary>
        public string ExportedBy { get; set; }
        /// <summary>
        /// When the Export was performed
        /// </summary>
        public DateTime? ExportedOn { get; set; }
        /// <summary>
        /// EDI Amendment number
        /// </summary>
        public int? Ediamendment { get; set; }
        /// <summary>
        /// EDI Acknowledgement number
        /// </summary>
        public string Ediacknowledgement { get; set; }
        public int FacilityId { get; set; }
        public int? DeliveryAddressId { get; set; }

        public virtual Address DeliveryAddress { get; set; }
        public virtual Facility Facility { get; set; }
        public virtual PaymentTerm PaymentTerms { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Address SupplierAddress { get; set; }
        public virtual ICollection<Edifile> Edifiles { get; set; }
        public virtual ICollection<PurchaseOrderAuthorisation> PurchaseOrderAuthorisations { get; set; }
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
    }
}

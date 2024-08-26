using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemInventoryTransaction
    {
        public ItemInventoryTransaction()
        {
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            ProductionContainers = new HashSet<ProductionContainer>();
            ProductionPackages = new HashSet<ProductionPackage>();
            ProductionProposedMovements = new HashSet<ProductionProposedMovement>();
            PurchaseInvoices = new HashSet<PurchaseInvoice>();
        }

        public int TransactionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemTransactionTypeId { get; set; }
        public DateTime Date { get; set; }
        public byte Complete { get; set; }
        public int? SupplierId { get; set; }
        public string ExternalReference { get; set; }
        public int? ItemLocationId { get; set; }
        public string YardReference { get; set; }
        public int? ItemClassificationId { get; set; }
        public int? UnitId { get; set; }
        public string CastReference { get; set; }
        public string TrackingNumber { get; set; }
        public int? ContractId { get; set; }
        public int? PhaseId { get; set; }
        public int? MarkId { get; set; }
        /// <summary>
        /// The method used to move the items to the new location
        /// </summary>
        public int? ShippingAgent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        /// <summary>
        /// The type of adjustment that is being made, 
        /// </summary>
        public int? AdjustmentTypeId { get; set; }
        public string Notes { get; set; }
        public int? ProductionWorkOrderId { get; set; }
        public int? CustomerId { get; set; }
        /// <summary>
        /// The Source for the Sales Order Delivery
        /// </summary>
        public int? SalesOrderId { get; set; }
        /// <summary>
        /// If an Invoice has been created for the Sales Order Delivery
        /// </summary>
        public bool SalesInvoiced { get; set; }
        public int? EmployeeId { get; set; }
        /// <summary>
        /// Used For Rec - Currenct rate when insert
        /// </summary>
        public double? ExchangeRate { get; set; }
        public int? FacilityId { get; set; }
        public bool Exported { get; set; }
        public string ExportedBy { get; set; }
        public DateTime? ExportedOn { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual ItemTransactionType ItemTransactionType { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<ProductionContainer> ProductionContainers { get; set; }
        public virtual ICollection<ProductionPackage> ProductionPackages { get; set; }
        public virtual ICollection<ProductionProposedMovement> ProductionProposedMovements { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
    }
}

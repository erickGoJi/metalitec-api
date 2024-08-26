using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkOrder
    {
        public ProductionWorkOrder()
        {
            EmployeeTimesheets = new HashSet<EmployeeTimesheet>();
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            ProductionContainerItems = new HashSet<ProductionContainerItem>();
            ProductionPackageItems = new HashSet<ProductionPackageItem>();
            ProductionProposedMovementItems = new HashSet<ProductionProposedMovementItem>();
            ProductionWorkOrderContracts = new HashSet<ProductionWorkOrderContract>();
            ProductionWorkOrderProcessQuantityHistories = new HashSet<ProductionWorkOrderProcessQuantityHistory>();
            ProductionWorkOrderProcesses = new HashSet<ProductionWorkOrderProcess>();
        }

        public int ProductionWorkOrderId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// ~1 - Open 2 - Closed
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// Contract, Contract Mark, Contract Item, Item, Service / Non Productive
        /// </summary>
        public int WorkOrderTypeId { get; set; }
        public int? ContractId { get; set; }
        public int? ContractMarkId { get; set; }
        public int? ContractItemId { get; set; }
        public int? ItemId { get; set; }
        public double Quantity { get; set; }
        public DateTime DateRequired { get; set; }
        public string Notes { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime UpdatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public int? Tempkey { get; set; }
        public byte[] RowVersion { get; set; }
        public int? PhaseId { get; set; }
        public int? LotId { get; set; }
        public int? DrawingDescriptionId { get; set; }

        public virtual ICollection<EmployeeTimesheet> EmployeeTimesheets { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<ProductionContainerItem> ProductionContainerItems { get; set; }
        public virtual ICollection<ProductionPackageItem> ProductionPackageItems { get; set; }
        public virtual ICollection<ProductionProposedMovementItem> ProductionProposedMovementItems { get; set; }
        public virtual ICollection<ProductionWorkOrderContract> ProductionWorkOrderContracts { get; set; }
        public virtual ICollection<ProductionWorkOrderProcessQuantityHistory> ProductionWorkOrderProcessQuantityHistories { get; set; }
        public virtual ICollection<ProductionWorkOrderProcess> ProductionWorkOrderProcesses { get; set; }
    }
}

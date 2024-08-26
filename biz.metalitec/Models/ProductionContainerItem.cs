using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionContainerItem
    {
        public int ProductionContainerItemId { get; set; }
        public int ProductionContainerId { get; set; }
        public int? ProductionWorkOrderId { get; set; }
        public int? ProductionWorkOrderContractId { get; set; }
        public int? FromProductionProcessId { get; set; }
        public int? ToProductionProcessId { get; set; }
        public int? ProductionPackageId { get; set; }
        public int? ProductionProposedMovementId { get; set; }
        /// <summary>
        /// The Quantity of the Extra.
        /// </summary>
        public double Quantity { get; set; }
        /// <summary>
        /// The Description of the Extra.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The unit Weight of the Extra.
        /// </summary>
        public double? Weight { get; set; }
        public string Notes { get; set; }
        public int? TransactionLineId { get; set; }

        public virtual ProductionProcess FromProductionProcess { get; set; }
        public virtual ProductionContainer ProductionContainer { get; set; }
        public virtual ProductionPackage ProductionPackage { get; set; }
        public virtual ProductionProposedMovement ProductionProposedMovement { get; set; }
        public virtual ProductionWorkOrder ProductionWorkOrder { get; set; }
        public virtual ProductionProcess ToProductionProcess { get; set; }
        public virtual ItemInventoryTransactionLine TransactionLine { get; set; }
    }
}

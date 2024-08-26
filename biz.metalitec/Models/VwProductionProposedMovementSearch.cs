using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwProductionProposedMovementSearch
    {
        public int ProductionDeliveryNoteId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int? StatusId { get; set; }
        public int LocationTypeId { get; set; }
        public string LocationType { get; set; }
        public int LocationId { get; set; }
        public string Location { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? TrailerId { get; set; }
        public string Trailer { get; set; }
        public int? ShippingAgentId { get; set; }
        public string ShippingAgent { get; set; }
        public int? Timbers { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public double? Quantity { get; set; }
        public string LineNotes { get; set; }
        public int? WorkOrderId { get; set; }
        public string WorkOrder { get; set; }
        public int? WorkOrderTypeId { get; set; }
        public string WorkOrderType { get; set; }
        public string FromProcess { get; set; }
        public string FromStage { get; set; }
        public string ToProcess { get; set; }
        public string ToStage { get; set; }
        public int? ProductionWorkOrderContractId { get; set; }
        public string Contract { get; set; }
        public string Phase { get; set; }
        public string Lot { get; set; }
        public string Mark { get; set; }
        public string ContractItem { get; set; }
        public int? ContractId { get; set; }
        public int? PhaseId { get; set; }
        public int? LotId { get; set; }
        public int? MarkId { get; set; }
        public int? MarkItemId { get; set; }
        public int? ContractItemId { get; set; }
    }
}

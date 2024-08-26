using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwProductionWorkOrderSearch
    {
        public int ProductionWorkOrderId { get; set; }
        public string Name { get; set; }
        public int? FacilityId { get; set; }
        public string Facility { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public int WorkOrderTypeId { get; set; }
        public string WorkOrderType { get; set; }
        public int? ContractId { get; set; }
        public string Contract { get; set; }
        public int? ItemId { get; set; }
        public string Item { get; set; }
        public double Quantity { get; set; }
        public double QuantityComplete { get; set; }
        public double QuantityReceivedInInventory { get; set; }
        public double QuantityCancelled { get; set; }
        public DateTime DateRequired { get; set; }
        public string Notes { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}

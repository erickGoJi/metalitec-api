using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionWorkOrderArchive
    {
        public int ProductionWorkOrderId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public int WorkOrderTypeId { get; set; }
        public int? ContractId { get; set; }
        public int? ContractMarkId { get; set; }
        public int? ContractItemId { get; set; }
        public int? ItemId { get; set; }
        public double Quantity { get; set; }
        public DateTime DateRequired { get; set; }
        public string Notes { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public int? Tempkey { get; set; }
    }
}

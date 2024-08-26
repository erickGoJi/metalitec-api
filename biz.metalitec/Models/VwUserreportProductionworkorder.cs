using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportProductionworkorder
    {
        public int ProductionWorkOrderId { get; set; }
        public string ProductionWorkOrder { get; set; }
        public string ProductionWorkOrderDescription { get; set; }
        public string Status { get; set; }
        public string WorkOrderType { get; set; }
        public string Contract { get; set; }
        public string Mark { get; set; }
        public string MarkItem { get; set; }
        public string Item { get; set; }
        public string SectionType { get; set; }
        public string Grade { get; set; }
        public double Quantity { get; set; }
        public DateTime DateRequired { get; set; }
        public string ProductionWorkOrderNotes { get; set; }
    }
}

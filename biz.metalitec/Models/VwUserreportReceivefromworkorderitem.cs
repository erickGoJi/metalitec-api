using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportReceivefromworkorderitem
    {
        public int ReceiveFromWorkOrderItemId { get; set; }
        public int ReceiveFromWorkOrderId { get; set; }
        public string LineType { get; set; }
        public int? ItemId { get; set; }
        public string Item { get; set; }
        public string SectionType { get; set; }
        public string Grade { get; set; }
        public string ItemLocation { get; set; }
        public string YardReference { get; set; }
        public string ItemClassification { get; set; }
        public string CostCode { get; set; }
        public string CostCentre { get; set; }
        public string PriceUnit { get; set; }
        public string CastReference { get; set; }
        public string TrackingNumber { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double Value { get; set; }
        public byte Complete { get; set; }
        public int? ProductionWorkOrderId { get; set; }
        public string WorkOrder { get; set; }
    }
}

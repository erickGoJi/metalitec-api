using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwContractDetailedlistingGetMark
    {
        public int MarkId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAssemblyMark { get; set; }
        public bool SiteAssembled { get; set; }
        public int? ParentMarkId { get; set; }
        public string ParentMark { get; set; }
        public double Quantity { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public string PaintFinish { get; set; }
        public string DrawingName { get; set; }
        public int ContractListingId { get; set; }
        public int ContractDrawingId { get; set; }
        public string DrawingDescription { get; set; }
        public bool CreateProductionWorkOrder { get; set; }
        public bool OnHold { get; set; }
        public string OnHoldNotes { get; set; }
        public int IsCamSplitMark { get; set; }
        public int IsCombinedMark { get; set; }
        public string ExecutionClass { get; set; }
        public bool IsPhaseGroup { get; set; }
    }
}

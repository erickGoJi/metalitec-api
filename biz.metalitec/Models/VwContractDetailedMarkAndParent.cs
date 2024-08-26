using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwContractDetailedMarkAndParent
    {
        public int? ParentDrawingId { get; set; }
        public string ParentDrawingName { get; set; }
        public int? ParentMarkId { get; set; }
        public string ParentMarkName { get; set; }
        public double? ParentQuantity { get; set; }
        public int MarkId { get; set; }
        public int ContractDrawingId { get; set; }
        public bool IsAssemblyMark { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public double TotalQuantity { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public double TotalWeight { get; set; }
        public double Area { get; set; }
        public double TotalArea { get; set; }
        public string PaintFinish { get; set; }
        public string CadFile { get; set; }
        public string Notes { get; set; }
        public bool SiteAssembled { get; set; }
    }
}

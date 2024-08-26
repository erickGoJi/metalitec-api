using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwContractDetailedlistingGetMarkitem
    {
        public int MarkItemId { get; set; }
        public bool OnHold { get; set; }
        public string OnHoldNotes { get; set; }
        public int MarkId { get; set; }
        public bool MainMember { get; set; }
        public string Type { get; set; }
        public string Mark { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string AltName { get; set; }
        public double Quantity { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public string PaintFinish { get; set; }
        public string PrelimMark { get; set; }
        public bool IgnoreForProcurement { get; set; }
        public bool CreateProductionWorkOrder { get; set; }
        public bool Backflush { get; set; }
        public int CutTypeId { get; set; }
        public double StartTopFlangeAngle { get; set; }
        public double EndTopFlangeAngle { get; set; }
        public double StartWebAngle { get; set; }
        public double EndWebAngle { get; set; }
        public double StartBottomFlangeAngle { get; set; }
        public double EndBottomFlangeAngle { get; set; }
        public int ItemTypeId { get; set; }
        public string Reference { get; set; }
        public int ContractItemId { get; set; }
        public int MarkItemTypeId { get; set; }
        public double Cambering { get; set; }
        public bool? Curved { get; set; }
        public double GrossLength { get; set; }
        public double Radius { get; set; }
        public double TopFlangeWidth { get; set; }
        public double TopFlangeThickness { get; set; }
        public string TopFlangeGrade { get; set; }
        public string TopFlangeWeld { get; set; }
        public double BottomFlangeWidth { get; set; }
        public double BottomFlangeThickness { get; set; }
        public string BottomFlangeGrade { get; set; }
        public string BottomFlangeWeld { get; set; }
        public double WebHeight { get; set; }
        public double WebThickness { get; set; }
        public string WebGrade { get; set; }
    }
}

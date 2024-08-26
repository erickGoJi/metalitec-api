using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportContractmarkitem
    {
        public int ContractMarkItemId { get; set; }
        public int ContractId { get; set; }
        public string Contract { get; set; }
        public string Phase { get; set; }
        public string Lot { get; set; }
        public double Quantity { get; set; }
        public double QuantityOrdered { get; set; }
        public double QuantityAllocated { get; set; }
        public double QuantityOutstanding { get; set; }
        public int ContractMarkId { get; set; }
        public bool MainMember { get; set; }
        public double MarkItemQuantity { get; set; }
        public int ItemId { get; set; }
        public string Item { get; set; }
        public string SectionType { get; set; }
        public string Grade { get; set; }
        public string MarkItem { get; set; }
        public string MarkItemType { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public string Reference { get; set; }
        public string CutType { get; set; }
        public string CamFile { get; set; }
        public bool ExactDimensions { get; set; }
        public double TopFlangeStartAngle { get; set; }
        public double TopFlangeEndAngle { get; set; }
        public double WebStartAngle { get; set; }
        public double WebEndAngle { get; set; }
        public double BottomFlangeStartAngle { get; set; }
        public double BottomFlangeEndAngle { get; set; }
        public bool NotNeededForAssembly { get; set; }
        public bool IgnoreForProcurement { get; set; }
        public bool CreateProductionWorkOrder { get; set; }
        public bool BackFlush { get; set; }
        public string PrelimMark { get; set; }
        public string PaintFinish { get; set; }
        public bool OnHold { get; set; }
        public string OnHoldNotes { get; set; }
        public string MarkItemNotes { get; set; }
        public string MarkItemRevisedBy { get; set; }
        public double MarkItemUnitArea { get; set; }
        public double MarkItemUnitWeight { get; set; }
        public string LottingStatus { get; set; }
        public string DetailItemStatus { get; set; }
        public DateTime? ReleasedOn { get; set; }
        public string ReleasedBy { get; set; }
        public int? EdifileId { get; set; }
    }
}

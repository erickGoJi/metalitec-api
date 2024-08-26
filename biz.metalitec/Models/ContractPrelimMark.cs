using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractPrelimMark
    {
        public ContractPrelimMark()
        {
            ContractPrelimMarkSequences = new HashSet<ContractPrelimMarkSequence>();
        }

        public int ContractPrelimMarkId { get; set; }
        public int ContractListingId { get; set; }
        public string Name { get; set; }
        public int ItemId { get; set; }
        public double Quantity { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public double Depth { get; set; }
        public double Area { get; set; }
        public int IgnoreForProcurement { get; set; }
        public string Details { get; set; }
        public string Reference { get; set; }
        public string CutType { get; set; }
        public string Angle1 { get; set; }
        public string Skew1 { get; set; }
        public string Angle2 { get; set; }
        public string Skew2 { get; set; }
        public string Finish { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string User3 { get; set; }
        public string Notes { get; set; }
        public int Version { get; set; }
        public string Drawing { get; set; }
        public string BottomFlangeGrade { get; set; }
        public double BottomFlangeThickness { get; set; }
        public string BottomFlangeWeld { get; set; }
        public double BottomFlangeWidth { get; set; }
        public double Cambering { get; set; }
        public int? ContractBatchId { get; set; }
        public double GrossLength { get; set; }
        public string OnHoldNotes { get; set; }
        public double Radius { get; set; }
        public string RevisedBy { get; set; }
        public string TopFlangeGrade { get; set; }
        public double TopFlangeThickness { get; set; }
        public string TopFlangeWeld { get; set; }
        public double TopFlangeWidth { get; set; }
        public string WebGrade { get; set; }
        public double WebHeight { get; set; }
        public double WebThickness { get; set; }

        public virtual ContractListing ContractListing { get; set; }
        public virtual Item Item { get; set; }
        public virtual ICollection<ContractPrelimMarkSequence> ContractPrelimMarkSequences { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportFitting
    {
        public int FittingId { get; set; }
        public string Fitting { get; set; }
        public string FittingDescription { get; set; }
        public int ItemId { get; set; }
        public string Item { get; set; }
        public string SectionType { get; set; }
        public string Grade { get; set; }
        public byte? Dimensional { get; set; }
        public byte? AsShaft { get; set; }
        public double MemberDepthFittingWidthPercentage { get; set; }
        public double MemberDepthFittingWidthAddition { get; set; }
        public double MemberDepthFittingThicknessPercentage { get; set; }
        public double MemberDepthFittingThicknessAddition { get; set; }
        public double MemberDepthFittingLengthPercentage { get; set; }
        public double MemberDepthFittingLengthAddition { get; set; }
        public double MemberWidthFittingWidthPercentage { get; set; }
        public double MemberWidthFittingWidthAddition { get; set; }
        public double MemberWidthFittingThicknessPercentage { get; set; }
        public double MemberWidthFittingThicknessAddition { get; set; }
        public double MemberWidthFittingLengthPercentage { get; set; }
        public double MemberWidthFittingLengthAddition { get; set; }
        public double MemberLengthFittingWidthPercentage { get; set; }
        public double MemberLengthFittingWidthAddition { get; set; }
        public double MemberLengthFittingThicknessPercentage { get; set; }
        public double MemberLengthFittingThicknessAddition { get; set; }
        public double MemberLengthFittingLengthPercentage { get; set; }
        public double MemberLengthFittingLengthAddition { get; set; }
        public double MemberThickFFittingWidthPercentage { get; set; }
        public double MemberThickFFittingWidthAddition { get; set; }
        public double MemberThickFFittingThicknessPercentage { get; set; }
        public double MemberThickFFittingThicknessAddition { get; set; }
        public double MemberThickFFittingLengthPercentage { get; set; }
        public double MemberThickFFittingLengthAddition { get; set; }
        public double MemberThickWFittingWidthPercentage { get; set; }
        public double MemberThickWFittingWidthAddition { get; set; }
        public double MemberThickWFittingThicknessPercentage { get; set; }
        public double MemberThickWFittingThicknessAddition { get; set; }
        public double MemberThickWFittingLengthPercentage { get; set; }
        public double MemberThickWFittingLengthAddition { get; set; }
        public double? FixedSizeWidth { get; set; }
        public double? FixedSizeThick { get; set; }
        public double? FixedSizeLength { get; set; }
        public byte Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
    }
}

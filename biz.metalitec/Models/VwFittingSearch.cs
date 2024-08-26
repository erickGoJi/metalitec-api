using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwFittingSearch
    {
        public int FittingId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Item { get; set; }
        public int SectionTypeId { get; set; }
        public string SectrionType { get; set; }
        public int? GradeId { get; set; }
        public string Grade { get; set; }
        public byte? DimensionalSize { get; set; }
        public byte? GradeAsShaft { get; set; }
        public double DepthWidthPercent { get; set; }
        public double DepthWidthDimension { get; set; }
        public double DepthThicknessPercent { get; set; }
        public double DepthThicknessDimension { get; set; }
        public double DepthLengthPercent { get; set; }
        public double DepthLengthDimension { get; set; }
        public double WidthWidthPercent { get; set; }
        public double WidthWidthDimension { get; set; }
        public double WidthThicknessPercent { get; set; }
        public double WidthThicknessDimension { get; set; }
        public double WidthLengthPercent { get; set; }
        public double WidthLengthDimension { get; set; }
        public double LengthWidthPercent { get; set; }
        public double LengthWidthDimension { get; set; }
        public double LengthThicknessPercent { get; set; }
        public double LengthThicknessDimension { get; set; }
        public double LengthLengthPercent { get; set; }
        public double LengthLengthDimension { get; set; }
        public double ThickFlangeWidthPercent { get; set; }
        public double ThickFlangeWidthDimension { get; set; }
        public double ThickFlangeThickPercent { get; set; }
        public double ThickFlangeThickDimension { get; set; }
        public double ThickFlangeLengthPercent { get; set; }
        public double ThickFlangeLengthDimension { get; set; }
        public double ThickWebWidthPercent { get; set; }
        public double ThickWebWidthDimension { get; set; }
        public double ThickWebThickPercent { get; set; }
        public double ThickWebThickDimension { get; set; }
        public double ThickWebLengthPercent { get; set; }
        public double ThickWebLengthDimension { get; set; }
        public double? FixedSizeWidth { get; set; }
        public double? FixedSizeThickness { get; set; }
        public double? FixedSizeLength { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public byte Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public int FacilityId { get; set; }
        public string Facility { get; set; }
    }
}

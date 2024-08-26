using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportNestingallocationitem
    {
        public int NestingResultAllocationId { get; set; }
        public int NestingResultId { get; set; }
        public int ItemId { get; set; }
        public string Item { get; set; }
        public string SectionType { get; set; }
        public string Grade { get; set; }
        public int ContractMarkId { get; set; }
        public string Mark { get; set; }
        public int ContractMarkItemId { get; set; }
        public string MarkItem { get; set; }
        public double Length { get; set; }
        public double? Width { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public double Quantity { get; set; }
        public string Contract { get; set; }
        public string Phase { get; set; }
        public string Lot { get; set; }
        public int? CuttingPlanId { get; set; }
    }
}

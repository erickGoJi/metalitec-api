using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwEstimateSubsectionGetbyid
    {
        public int EstimateSubSectionId { get; set; }
        public int EstimateId { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public int? BoqunitId { get; set; }
        public string Boqunit { get; set; }
        public int StartNumber { get; set; }
        public int Increment { get; set; }
        public int? SortOrder { get; set; }
        public string Notes { get; set; }
    }
}

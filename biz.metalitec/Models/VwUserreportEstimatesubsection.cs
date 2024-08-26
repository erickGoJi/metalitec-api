using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportEstimatesubsection
    {
        public int EstimateSubSectionId { get; set; }
        public int EstimateId { get; set; }
        public string Estimate { get; set; }
        public string Subsection { get; set; }
        public double Quantity { get; set; }
        public string SubsectionDescription { get; set; }
        public string BoqPriceUnit { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportEstimatesubsectionset
    {
        public int EstimateSubsectionSetId { get; set; }
        public string SubsectionSet { get; set; }
        public string SetType { get; set; }
        public string Subsection { get; set; }
        public double? Quantity { get; set; }
        public string SubsectionDescription { get; set; }
        public string BoqPriceUnit { get; set; }
    }
}

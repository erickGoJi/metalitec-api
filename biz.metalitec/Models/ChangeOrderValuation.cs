using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ChangeOrderValuation
    {
        public int ChangeOrderValuationId { get; set; }
        public int? ChangeOrderId { get; set; }
        public int? CostCodeId { get; set; }
        public double? Value { get; set; }
        public double? Weight { get; set; }
        public double? Hours { get; set; }
        public double? Area { get; set; }
        public int? EstimateId { get; set; }
        public int? EstimateSubSectionId { get; set; }
        public string LineDescription { get; set; }

        public virtual ChangeOrder ChangeOrder { get; set; }
        public virtual CostCode CostCode { get; set; }
        public virtual Estimate Estimate { get; set; }
    }
}

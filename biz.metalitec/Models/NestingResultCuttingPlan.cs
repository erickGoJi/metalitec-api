using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestingResultCuttingPlan
    {
        public int CuttingPlanId { get; set; }
        public string CuttingPlanText { get; set; }
        public int Chksum { get; set; }
        public string CuttingPlanDxf { get; set; }
    }
}

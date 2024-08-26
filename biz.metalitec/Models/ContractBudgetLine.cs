using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractBudgetLine
    {
        public int ContractBudgetLineId { get; set; }
        public int ContractBudgetId { get; set; }
        public int CostCodeId { get; set; }
        public byte DateBand { get; set; }
        public double? EstimatedValue { get; set; }
        public double? EstimatedWeight { get; set; }
        public double? EstimatedArea { get; set; }
        public double? EstimatedHours { get; set; }
        public int? EstimateId { get; set; }
        public double Value { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public double Hours { get; set; }

        public virtual ContractBudget ContractBudget { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwEstimateassemblyitemFittingGetbyid
    {
        public int EstimateAssemblyItemFittingId { get; set; }
        public int EstimateAssemblyItemId { get; set; }
        public int FittingId { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public int PriceSourceId { get; set; }
        public string CostCode { get; set; }
        public string PriceSource { get; set; }
    }
}

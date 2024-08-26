using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestResultsEstimateItemFitting
    {
        public int NestResultsEstimateItemFittingId { get; set; }
        public int NestSourceTypeId { get; set; }
        public int SourceKey { get; set; }
        public int ItemId { get; set; }
        public int EstimateItemFittingId { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public int StockId { get; set; }
        public int Last { get; set; }
        public int? SourceSubKey { get; set; }
    }
}

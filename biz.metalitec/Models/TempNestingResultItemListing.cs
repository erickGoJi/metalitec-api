using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class TempNestingResultItemListing
    {
        public string SessionId { get; set; }
        public int NestingResultItemListingId { get; set; }
        public int NestResultId { get; set; }
        public int? NestingResultAllocationId { get; set; }
        public int? SequenceId { get; set; }
        public int? ContractMarkPhaseLotItemId { get; set; }
        public int ItemId { get; set; }
        public double Quantity { get; set; }
        public int? StockId { get; set; }
        public double Length { get; set; }
        public int? LinkId { get; set; }
        public double? Width { get; set; }
    }
}

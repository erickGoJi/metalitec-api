using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestingResultItemListingArchive
    {
        public int NestingResultItemListingId { get; set; }
        public int NestResultId { get; set; }
        public int? NestingResultAllocationId { get; set; }
        public int? SequenceId { get; set; }
        public int? ContractMarkPhaseLotItemId { get; set; }
        public int ItemId { get; set; }
        public int? ItemUsedId { get; set; }
        public double Quantity { get; set; }
        public double Length { get; set; }
        public double? Width { get; set; }
        public int? LinkId { get; set; }
        public int SequenceOnBar { get; set; }
        public bool RotatedX { get; set; }
        public bool RotatedY { get; set; }
        public bool RotatedZ { get; set; }
        public double Waste { get; set; }
        public bool Accept { get; set; }
        public int? StockId { get; set; }
        public int QuantityCut { get; set; }
        public string Nriaux1 { get; set; }
        public string Nriaux2 { get; set; }
        public string Nriaux3 { get; set; }
        public int? ContractMarkItemInstanceId { get; set; }
        public int? NestingResultItemDesignId { get; set; }
        public int? SavedContractMarkItemInstanceId { get; set; }

        public virtual ContractMarkPhaseLotItem ContractMarkPhaseLotItem { get; set; }
        public virtual ContractPrelimMarkSequence Sequence { get; set; }
    }
}

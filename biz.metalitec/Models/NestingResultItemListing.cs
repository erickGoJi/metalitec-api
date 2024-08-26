using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestingResultItemListing
    {
        public NestingResultItemListing()
        {
            ProductionWorkOrderContracts = new HashSet<ProductionWorkOrderContract>();
        }

        public int NestingResultItemListingId { get; set; }
        /// <summary>
        /// Header link
        /// </summary>
        public int NestResultId { get; set; }
        public int? NestingResultAllocationId { get; set; }
        /// <summary>
        /// The prelim marksequenceID
        /// </summary>
        public int? SequenceId { get; set; }
        /// <summary>
        /// The detailed CMPLIID
        /// </summary>
        public int? ContractMarkPhaseLotItemId { get; set; }
        /// <summary>
        /// THIS MUST BE THE SAME AS ON THE CONTRACTITEM TABLE - POSSIBLY REMOVE!
        /// </summary>
        public int ItemId { get; set; }
        public double Quantity { get; set; }
        /// <summary>
        /// DO NOT USE!!! REMOVE LATER
        /// </summary>
        public int? StockId { get; set; }
        public double Length { get; set; }
        public int? LinkId { get; set; }
        public double? Width { get; set; }
        public int? ItemUsedId { get; set; }
        /// <summary>
        /// For angled nesting - indicates where on the bar this item will be cut from
        /// </summary>
        public int SequenceOnBar { get; set; }
        /// <summary>
        /// Angle Nesting - Has the bar been rotated around the X-Axis
        /// </summary>
        public bool RotatedX { get; set; }
        /// <summary>
        /// Angle Nesting - Has the bar been rotated around the Y-Axis
        /// </summary>
        public bool RotatedY { get; set; }
        /// <summary>
        /// Angle Nesting - Has the bar been rotated around the Z-Axis
        /// </summary>
        public bool RotatedZ { get; set; }
        /// <summary>
        /// The waste because of the sawblade or angle cut - This is not the offcut!
        /// </summary>
        public double Waste { get; set; }
        /// <summary>
        /// If the item is accepted on the current nest
        /// </summary>
        public bool? Accept { get; set; }
        public int QuantityCut { get; set; }
        public string Nriaux1 { get; set; }
        public string Nriaux2 { get; set; }
        public string Nriaux3 { get; set; }
        public int? NestingResultItemDesignId { get; set; }
        public int? ContractMarkItemInstanceId { get; set; }
        public int? SavedContractMarkItemInstanceId { get; set; }

        public virtual ContractMarkPhaseLotItem ContractMarkPhaseLotItem { get; set; }
        public virtual NestingResult NestResult { get; set; }
        public virtual NestingResultAllocation NestingResultAllocation { get; set; }
        public virtual ContractPrelimMarkSequence Sequence { get; set; }
        public virtual ICollection<ProductionWorkOrderContract> ProductionWorkOrderContracts { get; set; }
    }
}

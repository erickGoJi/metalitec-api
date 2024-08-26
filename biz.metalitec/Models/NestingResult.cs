using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestingResult
    {
        public NestingResult()
        {
            Edifiles = new HashSet<Edifile>();
            NestingResultItemListings = new HashSet<NestingResultItemListing>();
            NestingResultSupplies = new HashSet<NestingResultSupply>();
            NestingResultSupplyLengths = new HashSet<NestingResultSupplyLength>();
        }

        public int NestResultId { get; set; }
        public int? ContractListingId { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// The status of the nest: 0 - Saved, 1 - Allocated/Complete, 2 - Part Complete (possibly in future, not implimented now)
        /// </summary>
        public int StatusId { get; set; }
        public int ContractBatchId { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int Version { get; set; }
        public double SawBladeThick { get; set; }
        public double GripEndZone { get; set; }
        public int? ProductionWorkStationId { get; set; }
        public byte NonUseEndZone { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// Source preferences as specified on front page of wizard. 1 - Supplier Lengths, 2 - Cut to Length, 3 - Mills standard lengths, 4 - Entered Lengths
        /// </summary>
        public byte MaterialSource { get; set; }
        public bool UseFreeInventory { get; set; }
        public bool UseFreePurchaseOrders { get; set; }
        /// <summary>
        /// 0 - is a Prelim nest or not matched, 1 - Contract, 2 - Batch, 3 - Mark
        /// </summary>
        public byte PrelimAllocation { get; set; }
        /// <summary>
        /// Autocut Settings
        /// </summary>
        public double? MillMinLength { get; set; }
        /// <summary>
        /// Autocut Settings
        /// </summary>
        public double? MillMaxLength { get; set; }
        /// <summary>
        /// Autocut Settings
        /// </summary>
        public double? MillLengthIncrement { get; set; }
        /// <summary>
        /// Autocut Settings
        /// </summary>
        public double? MinReuseLength { get; set; }
        /// <summary>
        /// Autocut Settings
        /// </summary>
        public int? MaxDiffStock { get; set; }
        /// <summary>
        /// Autocut Settings
        /// </summary>
        public int? MaxDiffPiece { get; set; }
        /// <summary>
        /// Autocut Settings
        /// </summary>
        public bool CostOptimiseMode { get; set; }
        /// <summary>
        /// Autocut Settings
        /// </summary>
        public byte? OptimiseEffortLevel { get; set; }
        /// <summary>
        /// Autocut Settings
        /// </summary>
        public int LowerLayout { get; set; }
        /// <summary>
        /// Autocut Settings
        /// </summary>
        public int PreferShortStock { get; set; }
        public byte IgnoreLast { get; set; }
        public int NestingEngine { get; set; }
        public byte EdilistingTypeId { get; set; }
        public bool UseMultipleSuppliers { get; set; }
        public bool UseSuppliers { get; set; }
        public string InventoryLocations { get; set; }
        public string RollingReferences { get; set; }
        public double AngleFillerGap { get; set; }
        public string Dxflocation { get; set; }
        public bool UseCam { get; set; }
        public bool UseDxf { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? DeliveryLocationId { get; set; }
        public int PofacilityId { get; set; }
        public Guid Guid { get; set; }
        public bool DisplayAvailableLengthsFlat { get; set; }
        public int PreferCam { get; set; }
        /// <summary>
        /// Whether to only use theoretical offcuts from the same contract
        /// </summary>
        public bool? ContractOffcutsOnly { get; set; }
        public byte InventoryAge { get; set; }
        /// <summary>
        /// Whether the nest respects the original offcut length/shape or re-nests the entire bar/sheet
        /// </summary>
        public byte NestToTheoreticalOffcut { get; set; }
        /// <summary>
        /// Whether the nest utilises surplus material from existing uncut nests
        /// </summary>
        public bool UseTheoreticalOffcuts { get; set; }
        public double? BottomEdgeClearance { get; set; }
        public double? LeftEdgeClearance { get; set; }
        public double? MillMaxPlength { get; set; }
        public double? MillMaxPwidth { get; set; }
        public double? MillMinPlength { get; set; }
        public double? MillMinPwidth { get; set; }
        public double? MillPlengthIncrement { get; set; }
        public double? MillPwidthIncrement { get; set; }
        public double? RightEdgeClearance { get; set; }
        public bool? RoundToNextIncrement { get; set; }
        public bool? RoundToNextPincrement { get; set; }
        public double? TopEdgeClearance { get; set; }
        public int? DeliveryAddressId { get; set; }
        public bool UseListedWeightArea { get; set; }
        public bool? NestTfromI { get; set; }
        public bool? UseSawingLength { get; set; }

        public virtual ContractBatch ContractBatch { get; set; }
        public virtual ContractListing ContractListing { get; set; }
        public virtual Address DeliveryAddress { get; set; }
        public virtual ICollection<Edifile> Edifiles { get; set; }
        public virtual ICollection<NestingResultItemListing> NestingResultItemListings { get; set; }
        public virtual ICollection<NestingResultSupply> NestingResultSupplies { get; set; }
        public virtual ICollection<NestingResultSupplyLength> NestingResultSupplyLengths { get; set; }
    }
}

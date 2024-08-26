using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestingResultArchive
    {
        public int NestResultId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ContractListingId { get; set; }
        public int ContractBatchId { get; set; }
        public int StatusId { get; set; }
        public double SawBladeThick { get; set; }
        public double GripEndZone { get; set; }
        public byte NonUseEndZone { get; set; }
        public double? AngleAllowance { get; set; }
        public int? ProductionWorkStationId { get; set; }
        public byte MaterialSource { get; set; }
        public bool UseFreeInventory { get; set; }
        public bool UseFreePurchaseOrders { get; set; }
        public bool UseMultipleSuppliers { get; set; }
        public bool UseSuppliers { get; set; }
        public byte PrelimAllocation { get; set; }
        public double? MillMinLength { get; set; }
        public double? MillMaxLength { get; set; }
        public double? MillLengthIncrement { get; set; }
        public double? MinReuseLength { get; set; }
        public int? MaxDiffStock { get; set; }
        public int? MaxDiffPiece { get; set; }
        public bool CostOptimiseMode { get; set; }
        public byte? OptimiseEffortLevel { get; set; }
        public int LowerLayout { get; set; }
        public int PreferShortStock { get; set; }
        public byte IgnoreLast { get; set; }
        public int NestingEngine { get; set; }
        public string InventoryLocations { get; set; }
        public byte EdilistingTypeId { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int Version { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? DeliveryLocationId { get; set; }
        public int? PofacilityId { get; set; }

        public virtual ContractBatch ContractBatch { get; set; }
        public virtual ContractListing ContractListing { get; set; }
    }
}

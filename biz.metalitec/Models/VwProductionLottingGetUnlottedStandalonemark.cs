using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwProductionLottingGetUnlottedStandalonemark
    {
        public int ContractListingId { get; set; }
        public int ContractDrawingId { get; set; }
        public int MarkId { get; set; }
        public bool OnHold { get; set; }
        public string OnHoldNotes { get; set; }
        public int ContractMarkPhaseId { get; set; }
        public string Drawing { get; set; }
        public bool SiteAssembled { get; set; }
        public string AssemblyMark { get; set; }
        public string Mark { get; set; }
        public string Description { get; set; }
        public string Phase { get; set; }
        public string MainMemberItemName { get; set; }
        public int? MainMemberItemId { get; set; }
        public double? MainMemberLength { get; set; }
        public double Quantity { get; set; }
        public double QuantityLotted { get; set; }
        public double QuantityToLot { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public string PaintFinish { get; set; }
        public int? CutTypeId { get; set; }
        public bool CreateProductionWorkOrder { get; set; }
        public string ExecutionClass { get; set; }
        public int PhaseId { get; set; }
    }
}

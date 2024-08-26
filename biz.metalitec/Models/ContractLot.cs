using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractLot
    {
        public ContractLot()
        {
            ContractLotUserDateValues = new HashSet<ContractLotUserDateValue>();
            ContractMarkPhaseLots = new HashSet<ContractMarkPhaseLot>();
            PlanningDetails = new HashSet<PlanningDetail>();
            PlanningLongRangeLineLotLinks = new HashSet<PlanningLongRangeLineLotLink>();
        }

        public int LotId { get; set; }
        public int ContractListingId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte DefaultLot { get; set; }
        public DateTime? FabricationDate { get; set; }
        public DateTime? DispatchDate { get; set; }
        public string FabricationTeam { get; set; }
        public string Color { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? MarkItemsRequiredByDate { get; set; }
        public DateTime? MarksRequiredByDate { get; set; }
        public DateTime? OnSiteDate { get; set; }
        public int? ExecutionClassId { get; set; }
        public DateTime? PaintDate { get; set; }

        public virtual ContractListing ContractListing { get; set; }
        public virtual ICollection<ContractLotUserDateValue> ContractLotUserDateValues { get; set; }
        public virtual ICollection<ContractMarkPhaseLot> ContractMarkPhaseLots { get; set; }
        public virtual ICollection<PlanningDetail> PlanningDetails { get; set; }
        public virtual ICollection<PlanningLongRangeLineLotLink> PlanningLongRangeLineLotLinks { get; set; }
    }
}

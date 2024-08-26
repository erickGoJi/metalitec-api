using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PlanningLongRange
    {
        public PlanningLongRange()
        {
            PlanningLongRangeLines = new HashSet<PlanningLongRangeLine>();
        }

        public int PlanningLongRangeId { get; set; }
        public int? FacilityId { get; set; }
        public int? ContractId { get; set; }
        public int? PhaseId { get; set; }
        public int? EstimateId { get; set; }
        public int? EstimateSubsectionId { get; set; }
        public string Description { get; set; }
        public bool? CapacityAvailable { get; set; }
        public Guid? Tempkey { get; set; }
        public int Version { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string Location { get; set; }
        public string Task { get; set; }
        public double? TotalTime { get; set; }
        public double? TotalWeight { get; set; }
        public double HoursPerWeight { get; set; }
        public string Shift { get; set; }

        public virtual ICollection<PlanningLongRangeLine> PlanningLongRangeLines { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractMarkPhase
    {
        public ContractMarkPhase()
        {
            ContractMarkPhaseLots = new HashSet<ContractMarkPhaseLot>();
        }

        public int ContractMarkPhaseId { get; set; }
        public int MarkId { get; set; }
        public int PhaseId { get; set; }
        public double Quantity { get; set; }
        public int StatusId { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual ContractMark Mark { get; set; }
        public virtual ContractPhase Phase { get; set; }
        public virtual ICollection<ContractMarkPhaseLot> ContractMarkPhaseLots { get; set; }
    }
}

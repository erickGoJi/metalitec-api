using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractPhase
    {
        public ContractPhase()
        {
            ContractMarkPhases = new HashSet<ContractMarkPhase>();
            ContractPrelimMarkSequences = new HashSet<ContractPrelimMarkSequence>();
            DocumentRevisions = new HashSet<DocumentRevision>();
            ItemReservationContracts = new HashSet<ItemReservationContract>();
            ItemReservations = new HashSet<ItemReservation>();
        }

        public int PhaseId { get; set; }
        public int ContractId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte DefaultPhase { get; set; }
        public DateTime? FabricationDate { get; set; }
        public DateTime? ErectionDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Color { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual ICollection<ContractMarkPhase> ContractMarkPhases { get; set; }
        public virtual ICollection<ContractPrelimMarkSequence> ContractPrelimMarkSequences { get; set; }
        public virtual ICollection<DocumentRevision> DocumentRevisions { get; set; }
        public virtual ICollection<ItemReservationContract> ItemReservationContracts { get; set; }
        public virtual ICollection<ItemReservation> ItemReservations { get; set; }
    }
}

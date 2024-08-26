using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractPrelimSequenceList
    {
        public ContractPrelimSequenceList()
        {
            ContractPrelimMarkSequences = new HashSet<ContractPrelimMarkSequence>();
        }

        public int ListId { get; set; }
        public int ContractListingId { get; set; }
        public string Name { get; set; }
        public DateTime? RequiredDate { get; set; }

        public virtual ContractListing ContractListing { get; set; }
        public virtual ICollection<ContractPrelimMarkSequence> ContractPrelimMarkSequences { get; set; }
    }
}

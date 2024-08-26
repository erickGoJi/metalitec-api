using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractPrelimMarkSequence
    {
        public ContractPrelimMarkSequence()
        {
            NestingResultItemListingArchives = new HashSet<NestingResultItemListingArchive>();
            NestingResultItemListings = new HashSet<NestingResultItemListing>();
        }

        public int SequenceId { get; set; }
        public int ContractPrelimMarkId { get; set; }
        public int PhaseId { get; set; }
        public int ListId { get; set; }
        public double Quantity { get; set; }
        public double QuantityOrdered { get; set; }
        public double QuantityAllocated { get; set; }
        public int StatusId { get; set; }
        public string ReleasedBy { get; set; }
        public DateTime? ReleasedOn { get; set; }
        public double QuantityOutstanding { get; set; }
        public int Version { get; set; }
        public int? EdifileId { get; set; }
        public int? ContractBatchId { get; set; }
        public int? SplitFromSequenceId { get; set; }

        public virtual ContractPrelimMark ContractPrelimMark { get; set; }
        public virtual Edifile Edifile { get; set; }
        public virtual ContractPrelimSequenceList List { get; set; }
        public virtual ContractPhase Phase { get; set; }
        public virtual ICollection<NestingResultItemListingArchive> NestingResultItemListingArchives { get; set; }
        public virtual ICollection<NestingResultItemListing> NestingResultItemListings { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractBatch
    {
        public ContractBatch()
        {
            ContractBatchContracts = new HashSet<ContractBatchContract>();
            NestingResultArchives = new HashSet<NestingResultArchive>();
            NestingResults = new HashSet<NestingResult>();
        }

        public int ContractBatchId { get; set; }
        public int? ContractId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual ICollection<ContractBatchContract> ContractBatchContracts { get; set; }
        public virtual ICollection<NestingResultArchive> NestingResultArchives { get; set; }
        public virtual ICollection<NestingResult> NestingResults { get; set; }
    }
}

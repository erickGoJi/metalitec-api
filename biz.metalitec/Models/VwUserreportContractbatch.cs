using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportContractbatch
    {
        public int ContractBatchId { get; set; }
        public int ContractId { get; set; }
        public string Contract { get; set; }
        public string Batch { get; set; }
        public string BatchDescription { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}

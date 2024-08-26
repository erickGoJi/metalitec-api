using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractMarkItemTransaction
    {
        public int MarkItemTransactionId { get; set; }
        public int MarkItemId { get; set; }
        public string TransactionId { get; set; }
        public int PhaseId { get; set; }
    }
}

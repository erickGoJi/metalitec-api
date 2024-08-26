using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestingResultArchiveLink
    {
        public int ContractId { get; set; }
        public int NestResultId { get; set; }
        public bool FullyArchived { get; set; }
    }
}

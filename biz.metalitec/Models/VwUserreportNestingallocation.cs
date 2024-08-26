using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportNestingallocation
    {
        public int NestingResultId { get; set; }
        public string NestingResult { get; set; }
        public string NestingResultDescription { get; set; }
        public DateTime NestingResultDate { get; set; }
        public int ContractId { get; set; }
        public string Contract { get; set; }
    }
}

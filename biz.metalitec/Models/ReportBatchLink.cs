using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ReportBatchLink
    {
        public int ReportBatchLinkId { get; set; }
        public int? ReportBatchId { get; set; }
        public int? ReportId { get; set; }
        public string DefaultPrinter { get; set; }
        public int? NoCopies { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ReportBatchGroup
    {
        public int ReportBatchGroupId { get; set; }
        public int? BatchGroup { get; set; }
        public int? ReportBatchId { get; set; }
        public int? ReportId { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}

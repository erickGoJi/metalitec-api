using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ReportBatch
    {
        public int ReportBatchId { get; set; }
        public string Name { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int? FacilityId { get; set; }
        public string Description { get; set; }
        public int? RunOption { get; set; }
    }
}

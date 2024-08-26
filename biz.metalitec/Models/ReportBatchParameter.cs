using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ReportBatchParameter
    {
        public int ReportBatchParameterId { get; set; }
        public int? ReportId { get; set; }
        public int? ReportBatchId { get; set; }
        public string ParameterName { get; set; }
        public int? IsVisible { get; set; }
        public string DefaultValue { get; set; }
    }
}

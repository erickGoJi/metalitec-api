using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemObjectReport
    {
        public int SystemObjectReportId { get; set; }
        public int? SystemObjectId { get; set; }
        public int? ReportId { get; set; }
        public int? ReportType { get; set; }
        public int? System { get; set; }
    }
}

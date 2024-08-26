using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class RoleReport
    {
        public int RoleReportId { get; set; }
        public int RoleId { get; set; }
        public int ReportType { get; set; }
        public int ReportId { get; set; }

        public virtual Role Role { get; set; }
    }
}

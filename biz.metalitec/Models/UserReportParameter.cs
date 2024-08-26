using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class UserReportParameter
    {
        public int UserReportParameterId { get; set; }
        public int UserReportId { get; set; }
        public int ReportViewColumnId { get; set; }
        public string Name { get; set; }
        public string DatabaseName { get; set; }
        public int ParameterTypeId { get; set; }
        public int ParameterFunctionId { get; set; }
        public string ParameterValue { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int Version { get; set; }

        public virtual ReportViewColumn ReportViewColumn { get; set; }
        public virtual UserReport UserReport { get; set; }
    }
}

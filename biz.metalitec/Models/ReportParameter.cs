using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ReportParameter
    {
        public int ReportParameterId { get; set; }
        public int ReportId { get; set; }
        public string ParameterName { get; set; }
        public string ParameterDataType { get; set; }
        public string DefaultValue { get; set; }
        public int? ControlType { get; set; }
        public string LookupName { get; set; }
        public int? LookupType { get; set; }
        public string ListValues { get; set; }
        public int SortOrder { get; set; }
        public int System { get; set; }
        public string LookupDependant { get; set; }
        public string LookupColumnWidths { get; set; }
        public string LookupDependant2 { get; set; }

        public virtual Report Report { get; set; }
    }
}

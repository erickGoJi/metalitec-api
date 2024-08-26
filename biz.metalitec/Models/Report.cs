using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Report
    {
        public Report()
        {
            ReportParameters = new HashSet<ReportParameter>();
        }

        public int ReportId { get; set; }
        public int SystemModuleId { get; set; }
        public string Name { get; set; }
        public string StoredProcedure { get; set; }
        public string FileName { get; set; }
        public string File { get; set; }
        public string Notes { get; set; }
        public byte? System { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        /// <summary>
        /// Display in Search Yes or No
        /// </summary>
        public bool Visible { get; set; }
        public byte ApplyTemplate { get; set; }
        public int ReportGroupId { get; set; }
        public int BitValue { get; set; }
        public byte IsTemplate { get; set; }
        public byte? Orientation { get; set; }

        public virtual ICollection<ReportParameter> ReportParameters { get; set; }
    }
}

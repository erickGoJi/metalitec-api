using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ReportViewColumn
    {
        public ReportViewColumn()
        {
            UserReportParameters = new HashSet<UserReportParameter>();
        }

        public int ReportViewColumnId { get; set; }
        public int ReportViewId { get; set; }
        public string Name { get; set; }
        public string ViewColumnName { get; set; }
        public bool PrimaryKey { get; set; }
        public bool ForeignKey { get; set; }
        public string LookupName { get; set; }
        public string DataType { get; set; }
        public int DefaultColumnWidth { get; set; }
        public bool IsWeight { get; set; }
        public bool IsArea { get; set; }
        public bool IsLength { get; set; }
        public bool IsWeightUnit { get; set; }

        public virtual ReportView ReportView { get; set; }
        public virtual ICollection<UserReportParameter> UserReportParameters { get; set; }
    }
}

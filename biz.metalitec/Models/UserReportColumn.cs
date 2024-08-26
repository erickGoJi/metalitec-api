using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class UserReportColumn
    {
        public int UserReportColumnId { get; set; }
        public int UserReportId { get; set; }
        public int ReportViewColumnId { get; set; }
        public int ColumnLocationIndex { get; set; }
        public int ColumnWidth { get; set; }
        public int? SummaryId { get; set; }
        public bool? GroupBy { get; set; }
        public int OrderById { get; set; }
        public bool DetailOrGrouped { get; set; }
        public bool? IsVisible { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int Version { get; set; }
    }
}

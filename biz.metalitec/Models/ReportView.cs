using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ReportView
    {
        public ReportView()
        {
            ReportViewColumns = new HashSet<ReportViewColumn>();
        }

        public int ReportViewId { get; set; }
        public int SystemModuleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DatabaseViewName { get; set; }

        public virtual ICollection<ReportViewColumn> ReportViewColumns { get; set; }
    }
}

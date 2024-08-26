using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class UserReport
    {
        public UserReport()
        {
            UserReportParameters = new HashSet<UserReportParameter>();
        }

        public int UserReportId { get; set; }
        public int SystemModuleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SqlwhereStatement { get; set; }
        public int MainReportViewId { get; set; }
        public int SecondaryReportViewId { get; set; }
        /// <summary>
        /// 1 = Portrait, 2 = Landscape
        /// </summary>
        public int Orientation { get; set; }
        /// <summary>
        /// Only display completed reports from the wizard
        /// </summary>
        public bool Completed { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int Version { get; set; }

        public virtual ICollection<UserReportParameter> UserReportParameters { get; set; }
    }
}

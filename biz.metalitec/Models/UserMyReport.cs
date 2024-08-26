using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class UserMyReport
    {
        public int UserMyReport1 { get; set; }
        public int UserId { get; set; }
        public int ReportId { get; set; }
        /// <summary>
        /// 1=System, 2=User
        /// </summary>
        public int ReportType { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ChangeOrderStatus
    {
        public int ChangeOrderStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Percent { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public byte System { get; set; }
        /// <summary>
        /// Change Orders with this Status are to be considered &quot;Approved&quot;.
        /// </summary>
        public bool IsApproved { get; set; }
    }
}

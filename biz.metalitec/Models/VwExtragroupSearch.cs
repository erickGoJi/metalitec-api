using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwExtragroupSearch
    {
        public int ExtraGroupId { get; set; }
        public string Name { get; set; }
        public int FacilityId { get; set; }
        public string Facility { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}

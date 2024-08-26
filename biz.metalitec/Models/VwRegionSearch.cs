using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwRegionSearch
    {
        public int RegionId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public byte? Enabled { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

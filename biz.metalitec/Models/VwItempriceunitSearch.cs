using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwItempriceunitSearch
    {
        public int UnitId { get; set; }
        public string Name { get; set; }
        public string BaseUnit { get; set; }
        public double? BaseUnitMultiple { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

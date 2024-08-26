using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractPriority
    {
        public int FacilityId { get; set; }
        public int ContractId { get; set; }
        public int Priority { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual Facility Facility { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class UserAuthorisationLimit
    {
        public int UserAuthorisationLimitId { get; set; }
        public int UserId { get; set; }
        public int CostCodeId { get; set; }
        public double Limit { get; set; }

        public virtual CostCode CostCode { get; set; }
        public virtual User User { get; set; }
    }
}

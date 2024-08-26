using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemObjectUserRestrictionUser
    {
        public int SystemObjectUserRestrictionUserId { get; set; }
        public int SystemObjectUserRestrictionId { get; set; }
        public int UserId { get; set; }

        public virtual SystemObjectUserRestriction SystemObjectUserRestriction { get; set; }
        public virtual User User { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemObjectUserRestriction
    {
        public SystemObjectUserRestriction()
        {
            SystemObjectUserRestrictionUsers = new HashSet<SystemObjectUserRestrictionUser>();
        }

        public int SystemObjectUserRestrictionId { get; set; }
        public int SystemObjectId { get; set; }
        public int SystemObjectKey { get; set; }
        public bool IsRestricted { get; set; }

        public virtual SystemObject SystemObject { get; set; }
        public virtual ICollection<SystemObjectUserRestrictionUser> SystemObjectUserRestrictionUsers { get; set; }
    }
}

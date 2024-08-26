using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class UserRole
    {
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int FacilityId { get; set; }

        public virtual Facility Facility { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}

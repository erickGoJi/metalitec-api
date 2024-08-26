using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class RoleObjectAction
    {
        public int RoleObjectActionId { get; set; }
        public int RoleId { get; set; }
        public int SystemObjectId { get; set; }
        public int SystemActionId { get; set; }

        public virtual Role Role { get; set; }
        public virtual SystemAction SystemAction { get; set; }
        public virtual SystemObject SystemObject { get; set; }
    }
}

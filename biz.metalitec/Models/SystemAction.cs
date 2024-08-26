using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemAction
    {
        public SystemAction()
        {
            RoleObjectActions = new HashSet<RoleObjectAction>();
            SystemObjectActions = new HashSet<SystemObjectAction>();
        }

        public int SystemActionId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RoleObjectAction> RoleObjectActions { get; set; }
        public virtual ICollection<SystemObjectAction> SystemObjectActions { get; set; }
    }
}

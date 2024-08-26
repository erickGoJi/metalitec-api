using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemModuleGroup
    {
        public SystemModuleGroup()
        {
            SystemModuleGroupModules = new HashSet<SystemModuleGroupModule>();
            SystemModuleGroupObjects = new HashSet<SystemModuleGroupObject>();
        }

        public int SystemModuleGroupId { get; set; }
        public string Name { get; set; }
        public byte? Active { get; set; }
        public int? Sort { get; set; }
        public int System { get; set; }
        public string Image { get; set; }

        public virtual ICollection<SystemModuleGroupModule> SystemModuleGroupModules { get; set; }
        public virtual ICollection<SystemModuleGroupObject> SystemModuleGroupObjects { get; set; }
    }
}

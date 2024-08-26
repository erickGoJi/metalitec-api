using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemModule
    {
        public SystemModule()
        {
            SystemModuleGroupModules = new HashSet<SystemModuleGroupModule>();
            SystemModuleObjects = new HashSet<SystemModuleObject>();
        }

        public int SystemModuleId { get; set; }
        public string Name { get; set; }
        public string MenuName { get; set; }
        public byte? Active { get; set; }
        public int? Sort { get; set; }
        public int System { get; set; }

        public virtual ICollection<SystemModuleGroupModule> SystemModuleGroupModules { get; set; }
        public virtual ICollection<SystemModuleObject> SystemModuleObjects { get; set; }
    }
}

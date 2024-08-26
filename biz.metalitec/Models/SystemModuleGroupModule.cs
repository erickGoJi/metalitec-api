using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemModuleGroupModule
    {
        public int SystemModuleGroupModuleId { get; set; }
        public int SystemModuleId { get; set; }
        public int SystemModuleGroupId { get; set; }
        public int System { get; set; }

        public virtual SystemModule SystemModule { get; set; }
        public virtual SystemModuleGroup SystemModuleGroup { get; set; }
    }
}

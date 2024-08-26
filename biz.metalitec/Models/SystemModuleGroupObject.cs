using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemModuleGroupObject
    {
        public int SystemModuleGroupObjectId { get; set; }
        public int SystemModuleGroupId { get; set; }
        public int SystemObjectId { get; set; }
        public int System { get; set; }

        public virtual SystemModuleGroup SystemModuleGroup { get; set; }
        public virtual SystemObject SystemObject { get; set; }
    }
}

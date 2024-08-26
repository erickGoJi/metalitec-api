using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemModuleObject
    {
        public int SystemModuleObjectId { get; set; }
        public int SystemModuleId { get; set; }
        public int SystemObjectId { get; set; }
        public int System { get; set; }

        public virtual SystemModule SystemModule { get; set; }
        public virtual SystemObject SystemObject { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemObjectAction
    {
        public int SystemObjectActionId { get; set; }
        public int SystemObjectId { get; set; }
        public int SystemActionId { get; set; }

        public virtual SystemAction SystemAction { get; set; }
        public virtual SystemObject SystemObject { get; set; }
    }
}

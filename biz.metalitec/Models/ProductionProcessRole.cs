using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionProcessRole
    {
        public int ProductionProcessRoleId { get; set; }
        public int ProductionProcessId { get; set; }
        public int RoleId { get; set; }
        public bool? AllowMoveFrom { get; set; }
        public bool AllowMoveTo { get; set; }
        public bool AllowMoveFromAndToComplete { get; set; }

        public virtual ProductionProcess ProductionProcess { get; set; }
    }
}

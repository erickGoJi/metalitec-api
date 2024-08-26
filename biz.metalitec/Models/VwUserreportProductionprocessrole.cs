using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportProductionprocessrole
    {
        public int ProductionProcessRoleId { get; set; }
        public int ProductionProcessId { get; set; }
        public string ProductionProcess { get; set; }
        public int RoleId { get; set; }
        public string Role { get; set; }
    }
}

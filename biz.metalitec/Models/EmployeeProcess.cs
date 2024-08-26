using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EmployeeProcess
    {
        public int EmployeeProcessId { get; set; }
        public int EmployeeId { get; set; }
        public int ProductionProcessId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ProductionProcess ProductionProcess { get; set; }
    }
}

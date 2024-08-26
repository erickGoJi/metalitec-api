using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class WorkstationProcess
    {
        public int WorkstationProcessId { get; set; }
        public int WorkstationId { get; set; }
        public int ProductionProcessId { get; set; }

        public virtual ProductionProcess ProductionProcess { get; set; }
        public virtual ProductionWorkStation Workstation { get; set; }
    }
}

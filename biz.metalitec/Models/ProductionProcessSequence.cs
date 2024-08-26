using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionProcessSequence
    {
        public int ProductionProcessSequenceId { get; set; }
        public int ProductionProcessId { get; set; }
        public int NextProductionProcessId { get; set; }

        public virtual ProductionProcess NextProductionProcess { get; set; }
        public virtual ProductionProcess ProductionProcess { get; set; }
    }
}

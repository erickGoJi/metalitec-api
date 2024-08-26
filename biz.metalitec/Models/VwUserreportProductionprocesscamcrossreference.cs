using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportProductionprocesscamcrossreference
    {
        public int ProductionProcessCamreferenceId { get; set; }
        public int ProductionProcessId { get; set; }
        public string ProductionProcess { get; set; }
        public string CamProcess { get; set; }
    }
}

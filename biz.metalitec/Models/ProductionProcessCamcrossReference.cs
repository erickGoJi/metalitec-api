using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionProcessCamcrossReference
    {
        public int ProductionProcessCamreferenceId { get; set; }
        public int ProductionProcessId { get; set; }
        public int CamprocessId { get; set; }

        public virtual ProductionProcess ProductionProcess { get; set; }
    }
}

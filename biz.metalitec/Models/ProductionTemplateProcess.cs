using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionTemplateProcess
    {
        public ProductionTemplateProcess()
        {
            ProductionTemplateProcessTimings = new HashSet<ProductionTemplateProcessTiming>();
        }

        public int ProductionTemplateProcessId { get; set; }
        public int ProductionTemplateId { get; set; }
        public int ProcessNumber { get; set; }
        public int ProductionProcessId { get; set; }
        public int? TempKey { get; set; }
        public bool AlwaysInclude { get; set; }

        public virtual ProductionProcess ProductionProcess { get; set; }
        public virtual ProductionTemplate ProductionTemplate { get; set; }
        public virtual ICollection<ProductionTemplateProcessTiming> ProductionTemplateProcessTimings { get; set; }
    }
}

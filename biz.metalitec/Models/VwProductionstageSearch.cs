using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwProductionstageSearch
    {
        public int ProductionStageId { get; set; }
        public string Name { get; set; }
        public int StageNumber { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}

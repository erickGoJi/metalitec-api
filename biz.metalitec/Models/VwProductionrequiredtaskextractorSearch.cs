using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwProductionrequiredtaskextractorSearch
    {
        public int ProductionRequiredTaskExtractorId { get; set; }
        public string RequiredTaskExtractorType { get; set; }
        public string WorkOrderType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public bool System { get; set; }
    }
}

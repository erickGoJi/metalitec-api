using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportProductiontemplate
    {
        public int ProductionTemplateId { get; set; }
        public string ProductionTemplate { get; set; }
        public string WorkOrderType { get; set; }
        public string WorkOrderCategory { get; set; }
        public string AssemblyType { get; set; }
        public string MarkItemType { get; set; }
        public byte Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public string ProductionTemplateNotes { get; set; }
    }
}

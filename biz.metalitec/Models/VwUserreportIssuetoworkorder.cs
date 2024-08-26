using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportIssuetoworkorder
    {
        public int IssueToWorkOrderId { get; set; }
        public string IssueToWorkOrder { get; set; }
        public string IssueToWorkOrderDescription { get; set; }
        public DateTime IssueToWorkOrderDate { get; set; }
        public byte Complete { get; set; }
        public string Contract { get; set; }
        public string Phase { get; set; }
        public int? ProductionWorkOrderId { get; set; }
        public string WorkOrder { get; set; }
        public string IssueToWorkOrderNotes { get; set; }
    }
}

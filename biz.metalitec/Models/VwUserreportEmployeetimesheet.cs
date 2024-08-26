using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportEmployeetimesheet
    {
        public int TimesheetId { get; set; }
        public int TimesheetEntryId { get; set; }
        public int EmployeeId { get; set; }
        public string Employee { get; set; }
        public string StartTime { get; set; }
        public string StopTime { get; set; }
        public DateTime TimesheetDate { get; set; }
        public string CostCode { get; set; }
        public string CostCentre { get; set; }
        public int? ContractId { get; set; }
        public string Contract { get; set; }
        public string ContractDescription { get; set; }
        public int? ProductionWorkOrderId { get; set; }
        public string WorkOrder { get; set; }
        public string WorkOrderDescription { get; set; }
        public int? ProductionProcessId { get; set; }
        public string Process { get; set; }
        public string ProcessDescription { get; set; }
        public int? ProductionWorkStationId { get; set; }
        public string WorkStation { get; set; }
        public string WorkStationDescription { get; set; }
        public double Minutes { get; set; }
        public double EmployeeHourlyRate { get; set; }
        public double WorkStationHourlyRate { get; set; }
        public string TimesheetNotes { get; set; }
        public bool Exported { get; set; }
        public DateTime? ExportedOn { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EmployeeTimesheet
    {
        public int TimesheetId { get; set; }
        public int TimesheetEntryId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public int CostCodeId { get; set; }
        public int? ContractId { get; set; }
        public int? WorkOrderId { get; set; }
        public int? ProductionWorkOrderProcessId { get; set; }
        public int? ProductionWorkStationId { get; set; }
        public double Minutes { get; set; }
        public double EmployeeHourlyRate { get; set; }
        public double WorkStationHourlyRate { get; set; }
        public string Notes { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? StopTime { get; set; }
        public int? ProductionProcessId { get; set; }
        public bool Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public bool Exported { get; set; }
        public string ExportedBy { get; set; }
        public DateTime? ExportedOn { get; set; }
        public int? EmployeeHourlyRateId { get; set; }
        public double ProcessHourlyRate { get; set; }
        public int? CurrencyId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ProductionWorkOrderProcess ProductionWorkOrderProcess { get; set; }
        public virtual ProductionWorkOrder WorkOrder { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwTransactioninterfaceEmployeetimesheet
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public int FacilityId { get; set; }
        public string Facility { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? StopTime { get; set; }
        public DateTime Date { get; set; }
        public double Minutes { get; set; }
        public string HourlyRateDescription { get; set; }
        public double EmployeeHourlyRate { get; set; }
        public double WorkstationHourlyRate { get; set; }
        public string TimesheetNotes { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Position { get; set; }
        public string ContractName { get; set; }
        public string ContractDescription { get; set; }
        public string Customer { get; set; }
        public string WorkOrderName { get; set; }
        public string WorkOrderDescription { get; set; }
        public double? WorkOrderQuantity { get; set; }
        public string WorkOrderNotes { get; set; }
        public string ProductionProcess { get; set; }
        public int? ProcessNumber { get; set; }
        public double? PerUnitMinutes { get; set; }
        public double? FixedMinutes { get; set; }
        public string WorkStationName { get; set; }
        public string WorkStationDescription { get; set; }
        public string CostCodeName { get; set; }
        public string CostCodeDescription { get; set; }
        public string CostCentreName { get; set; }
        public string WorkOrderStatus { get; set; }
        public string WorkOrderType { get; set; }
        public string MarkName { get; set; }
        public string MarkItemName { get; set; }
        public string ItemName { get; set; }
        public string DisplayTimeUnit { get; set; }
        public int ContractId { get; set; }
        public int? ProductionWorkOrderId { get; set; }
        public int? ProductionWorkOrderProcessId { get; set; }
        public int? ProductionWorkStationId { get; set; }
        public int CostCodeId { get; set; }
        public int TimesheetId { get; set; }
        public int TimesheetEntryId { get; set; }
    }
}

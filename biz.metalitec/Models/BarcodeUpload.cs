using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class BarcodeUpload
    {
        public int BarcodeUploadId { get; set; }
        public int BarcodeInterfaceId { get; set; }
        public string SessionGuid { get; set; }
        /// <summary>
        /// ~0 - transferred but not applied, 1 success, fail
        /// </summary>
        public byte Status { get; set; }
        public string SourceEmployee { get; set; }
        public string SourceBarCode { get; set; }
        public string SourceDateTime { get; set; }
        public int Quantity { get; set; }
        public double TotalDuration { get; set; }
        public int? EmployeeId { get; set; }
        /// <summary>
        /// ~P - Process, W - Work Order
        /// </summary>
        public byte? CommandType { get; set; }
        public int? ProductionWorkOrderId { get; set; }
        public int? ProductionWorkOrderContractId { get; set; }
        public int? ProcessNumber { get; set; }
        public string Stage { get; set; }
        public string CurrentProcess { get; set; }
        public int? CurrentProcessId { get; set; }
        public string Mark { get; set; }
        public string MarkItem { get; set; }
        public string Phase { get; set; }
        public string Lot { get; set; }
        public string ProductionProcess { get; set; }
        public int? ProductionProcessId { get; set; }
        public bool Ignore { get; set; }
        public byte InvalidType { get; set; }
        public bool WaitingToProcess { get; set; }
        public bool CreateTimesheet { get; set; }
        public string Contract { get; set; }
        public bool OnHold { get; set; }
        public string OnHoldNotes { get; set; }
        public bool? Move { get; set; }
        public DateTime? StopTime { get; set; }
        public bool AssemblyMark { get; set; }
        public string SourceContract { get; set; }
        public int? AddToNote { get; set; }
    }
}

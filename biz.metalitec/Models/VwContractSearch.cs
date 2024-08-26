using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwContractSearch
    {
        public int ContractId { get; set; }
        public long? Priority { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Project { get; set; }
        public string Customer { get; set; }
        public string Enquiry { get; set; }
        public string Estimate { get; set; }
        public int? FacilityId { get; set; }
        public string Facility { get; set; }
        public string Currency { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public bool CadDocumentManagement { get; set; }
        public bool CamDocumentManagement { get; set; }
        public bool BimreviewDocumentManagement { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int ContractTypeId { get; set; }
        public int StatusId { get; set; }
        public double PrelimWeight { get; set; }
        public double PrelimArea { get; set; }
        public double TotalScheduleValue { get; set; }
        public double TotalScheduleInvoices { get; set; }
        public double GrandTotalInvoices { get; set; }
        public double TotalCompletedPlusMaterialsStored { get; set; }
        public double TotalLessRetention { get; set; }
        public double TotalRetention { get; set; }
        public DateTime? RetentionDueDate { get; set; }
        public double BalanceToFinish { get; set; }
        public string Notes { get; set; }
    }
}

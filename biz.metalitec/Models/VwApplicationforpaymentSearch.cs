using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwApplicationforpaymentSearch
    {
        public int ApplicationForPaymentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime? ApplicationDue { get; set; }
        public int ApplicationNo { get; set; }
        public int? SalesInvoiceId { get; set; }
        public string SalesInvoice { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public int FacilityId { get; set; }
        public string Facility { get; set; }
        public int ContractId { get; set; }
        public string Contract { get; set; }
        public string ContractDescription { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public double TotalClaimThisPeriod { get; set; }
        public double TotalMaterialsStored { get; set; }
        public double TotalRetentionThisPeriod { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

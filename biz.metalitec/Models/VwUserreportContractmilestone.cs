using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportContractmilestone
    {
        public int ContractInvoiceScheduleId { get; set; }
        public int ContractId { get; set; }
        public string Contract { get; set; }
        public string ContractMilestone { get; set; }
        public DateTime ExpectedInvoiceDate { get; set; }
        public double ExpectedInvoiceValue { get; set; }
        public string CostCode { get; set; }
        public string CostCentre { get; set; }
        public double ActualInvoiceValue { get; set; }
    }
}

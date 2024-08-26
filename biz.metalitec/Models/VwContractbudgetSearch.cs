using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwContractbudgetSearch
    {
        public int ContractBudgetId { get; set; }
        public int ContractId { get; set; }
        public string Name { get; set; }
        public bool IsMasterBudget { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string Facility { get; set; }
        public int FacilityId { get; set; }
    }
}

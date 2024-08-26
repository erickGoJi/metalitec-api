using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwProductionAssemblySearch
    {
        public int TransactionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ContractId { get; set; }
        public string Contract { get; set; }
        public DateTime Date { get; set; }
        public byte Complete { get; set; }
        public string Marks { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string LocationFacility { get; set; }
        public int? FacilityId { get; set; }
    }
}

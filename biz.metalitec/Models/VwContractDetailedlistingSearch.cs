using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwContractDetailedlistingSearch
    {
        public int ContractListingId { get; set; }
        public int ContractId { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }
        public string Project { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public int NoOfDrawings { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int StatusId { get; set; }
        public string Facility { get; set; }
        public int FacilityId { get; set; }
        public string Notes { get; set; }
    }
}

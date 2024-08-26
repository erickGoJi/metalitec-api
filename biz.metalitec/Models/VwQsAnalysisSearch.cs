using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwQsAnalysisSearch
    {
        public int QsanalysisId { get; set; }
        public string Name { get; set; }
        public int? ContractId { get; set; }
        public string Contract { get; set; }
        public int? EstimateId { get; set; }
        public string Estimate { get; set; }
        public int? FacilityId { get; set; }
        public string Facility { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}

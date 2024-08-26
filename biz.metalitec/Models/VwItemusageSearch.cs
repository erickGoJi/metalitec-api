using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwItemusageSearch
    {
        public int ItemUsageId { get; set; }
        public string Name { get; set; }
        public string Item { get; set; }
        public int SectionTypeId { get; set; }
        public string SectionType { get; set; }
        public int? GradeId { get; set; }
        public string Grade { get; set; }
        public int FacilityId { get; set; }
        public string Facility { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public byte Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
    }
}

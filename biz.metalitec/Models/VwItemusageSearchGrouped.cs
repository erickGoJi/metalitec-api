using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwItemusageSearchGrouped
    {
        public int ItemUsageId { get; set; }
        public string Name { get; set; }
        public int? Item { get; set; }
        public int? SectionTypeId { get; set; }
        public int? SectionType { get; set; }
        public int? GradeId { get; set; }
        public int? Grade { get; set; }
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

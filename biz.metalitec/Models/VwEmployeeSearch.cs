using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwEmployeeSearch
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string EmployeeCode { get; set; }
        public string CostCode { get; set; }
        public string CostCodeDescription { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FacilityId { get; set; }
        public string Facility { get; set; }
        public byte Active { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string Process { get; set; }
    }
}

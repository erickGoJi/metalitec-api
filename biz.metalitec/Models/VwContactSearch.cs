using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwContactSearch
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int CompanyId { get; set; }
        public int CompanyTypeId { get; set; }
        public string Company { get; set; }
        public string JobTitle { get; set; }
        public string CompanyNumber { get; set; }
        public string HomeNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string AlternativeEmail { get; set; }
        public string DefaultReason { get; set; }
        public int? DefaultResponseDays { get; set; }
        public int? DefaultCopies { get; set; }
        public string EmailPriority { get; set; }
        public int? PriorityId { get; set; }
        public double? DefaultMaxEmailSize { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int AddressSourceTypeId { get; set; }
        public bool? Active { get; set; }
    }
}

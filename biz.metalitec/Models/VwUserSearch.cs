using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserSearch
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public int Active { get; set; }
        public DateTime Expires { get; set; }
        public string Language { get; set; }
        public string Role { get; set; }
        public int? FacilityId { get; set; }
        public string Facility { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

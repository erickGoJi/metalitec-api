using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwCustomerListingSearch
    {
        public int ListingDetailId { get; set; }
        public string ListingType { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Customer { get; set; }
        public string Project { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

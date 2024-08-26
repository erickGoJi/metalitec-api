using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwCustomerSearch
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string CustomerType { get; set; }
        public string Contact { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string ExternalReference { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string Ediemail { get; set; }
        public string Edireference { get; set; }
        public string EdifileFormat { get; set; }
        public string SubjectHeaderSuffix { get; set; }
        public string Notes { get; set; }
    }
}

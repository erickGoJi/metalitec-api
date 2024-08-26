using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwDocumentPackageSearch
    {
        public int DocumentPackageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Copies { get; set; }
        public string Reason { get; set; }
        public string Notes { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}

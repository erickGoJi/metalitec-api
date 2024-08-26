using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwDocumentStatusSearch
    {
        public int DocumentStatusId { get; set; }
        public string Name { get; set; }
        public int? Percent { get; set; }
        public bool? IsApproved { get; set; }
        public bool? IsReviewed { get; set; }
        public bool? IsCompleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwDocumentRevisionSearch
    {
        public int DocumentRevisionId { get; set; }
        public DateTime? UpdateOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}

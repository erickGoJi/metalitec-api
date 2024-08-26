using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwDocumentRevisionCodeSearch
    {
        public int DocumentRevisionCodeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Sequence { get; set; }
        public DateTime? UpdateOn { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}

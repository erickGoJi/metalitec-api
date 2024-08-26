using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportRollreference
    {
        public int RollReferenceId { get; set; }
        public string RollReferenceName { get; set; }
        public string RollReferenceDescription { get; set; }
        public int SupplierId { get; set; }
        public string Supplier { get; set; }
        public string RollReference { get; set; }
        public DateTime? RollDate { get; set; }
        public string Item { get; set; }
        public string SectionType { get; set; }
        public string Grade { get; set; }
    }
}

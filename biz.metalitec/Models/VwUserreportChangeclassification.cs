using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportChangeclassification
    {
        public int ChangeClassificationId { get; set; }
        public string ClassificationChange { get; set; }
        public string ClassificationChangeDescription { get; set; }
        public DateTime ClassificationChangeDate { get; set; }
        public byte Complete { get; set; }
        public string ItemClassification { get; set; }
        public string ClassificationChangeNotes { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EnquiryMeetingNote
    {
        public int EnquiryMeetingNoteId { get; set; }
        public string Note { get; set; }
        public bool? Template { get; set; }
        public string TemplateName { get; set; }
        public int? EnquiryId { get; set; }
        public int? EnquiryMeetingNoteTypeId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class WebSession
    {
        public int WebSessionId { get; set; }
        public string SessionId { get; set; }
        public Guid? SessionLogId { get; set; }
        public string UserName { get; set; }
        public int FacilityId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastPulseDate { get; set; }
    }
}

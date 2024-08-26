using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class HotfixLog
    {
        public int HotfixLogId { get; set; }
        public string HotfixName { get; set; }
        public string HotfixCode { get; set; }
        public string Username { get; set; }
        public DateTime? RunDate { get; set; }
    }
}

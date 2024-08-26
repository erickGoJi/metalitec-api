using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class StruMisSession
    {
        public string SessionId { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string Lid { get; set; }
        public int? Dib { get; set; }
        public DateTime? Dte { get; set; }
        public string Cid { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class AuditLog
    {
        public int AuditId { get; set; }
        public DateTime? EventTime { get; set; }
        public string ActionName { get; set; }
        public string DatabaseName { get; set; }
        public string ServerPrincipalName { get; set; }
        public string DatabasePrincipalName { get; set; }
        public string ObjectName { get; set; }
        public string Statement { get; set; }
        public long? AuditFileOffset { get; set; }
        public string FileName { get; set; }
        public int IsAuditInsert { get; set; }
    }
}

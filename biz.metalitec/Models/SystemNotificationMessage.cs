using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemNotificationMessage
    {
        public int MessageId { get; set; }
        public int SourceSystemObjectId { get; set; }
        public int SystemObjectKey { get; set; }
        /// <summary>
        /// Insert = 1, Update = 2, Delete = 3
        /// </summary>
        public int EventType { get; set; }
        public string Xml { get; set; }
        public bool Processed { get; set; }
        public DateTime? ProcessedOn { get; set; }
        public string ProcessedBy { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool? Failed { get; set; }
        public bool? Processing { get; set; }
    }
}

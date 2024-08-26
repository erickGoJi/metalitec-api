using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Updated
    {
        public int UpdatedId { get; set; }
        public string Table { get; set; }
        public string IdentityColumn { get; set; }
        public int? IdentityId { get; set; }
        public string ColumnUpdated { get; set; }
        public string FromValue { get; set; }
        public string ToValue { get; set; }
        public string Notes { get; set; }
        public string Xml { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}

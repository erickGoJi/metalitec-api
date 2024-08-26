using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemObjectHiddenField
    {
        public int SystemObjectHiddenFieldId { get; set; }
        public int? SystemObjectId { get; set; }
        public string FieldName { get; set; }
        public string FieldLabel { get; set; }
        public int? OverrideSystemObjectId { get; set; }
        public int? OverrideSourceKey { get; set; }
        public byte? Hidden { get; set; }
    }
}

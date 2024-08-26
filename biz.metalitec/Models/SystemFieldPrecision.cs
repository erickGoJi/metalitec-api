using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemFieldPrecision
    {
        public int SystemFieldPrecisionId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string PrecisionKey { get; set; }
    }
}

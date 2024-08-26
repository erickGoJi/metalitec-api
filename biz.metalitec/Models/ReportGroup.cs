using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ReportGroup
    {
        public int ReportGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public byte System { get; set; }
        public int? SystemModuleId { get; set; }
    }
}

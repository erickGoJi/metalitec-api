using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwSystemdataportSearch
    {
        public int SystemDataPortId { get; set; }
        public string Module { get; set; }
        public string SystemObject { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int ModuleSort { get; set; }
        public int? ObjectSort { get; set; }
        public string FileName { get; set; }
        public string FileExtention { get; set; }
        public bool HasExportFilter { get; set; }
    }
}

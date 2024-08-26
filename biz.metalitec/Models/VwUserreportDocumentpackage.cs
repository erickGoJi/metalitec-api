using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportDocumentpackage
    {
        public int DocumentPackageId { get; set; }
        public string DocumentPackage { get; set; }
        public string DocumentPackageDescription { get; set; }
        public int? Copies { get; set; }
        public string Reason { get; set; }
    }
}

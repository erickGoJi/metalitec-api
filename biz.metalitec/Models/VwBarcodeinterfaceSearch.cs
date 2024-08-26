using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwBarcodeinterfaceSearch
    {
        public int BarcodeinterfaceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DefaultFilePath { get; set; }
        public string ArchiveFilePath { get; set; }
        public string FileExtention { get; set; }
        public byte System { get; set; }
    }
}

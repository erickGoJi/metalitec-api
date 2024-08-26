using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemInventoryTestCertMap
    {
        public int? ItemInventoryId { get; set; }
        public int? ItemSiteInventoryId { get; set; }
        public string DocumentId { get; set; }
        public string DocumentRevisionId { get; set; }
        public string CertificateNumber { get; set; }
        public string TestCertificateName { get; set; }
        public int? MultiCertificateNumber { get; set; }
        public int? Multi { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class DocumentAdditionalDatum
    {
        public int DocumentId { get; set; }
        public string CastReference { get; set; }
        public int? SupplierId { get; set; }
        /// <summary>
        /// 1 - Test Certificate 
        /// </summary>
        public int DocumentAdditionalDataType { get; set; }
        public string PurchaseOrder { get; set; }
        public string Receipt { get; set; }
        public string CertificateNumber { get; set; }
        public int DocumentAdditionalDataId { get; set; }
        public string Cemark { get; set; }
        public bool GroupedTrackingNumber { get; set; }
        public int? ItemId { get; set; }
        public string MillOrigin { get; set; }
        public string TrackingNumber { get; set; }
    }
}

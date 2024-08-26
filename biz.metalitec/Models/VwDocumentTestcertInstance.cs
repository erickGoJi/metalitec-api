using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwDocumentTestcertInstance
    {
        public int? ItemId { get; set; }
        public int? SupplierId { get; set; }
        public string MillOrigin { get; set; }
        public string CastReference { get; set; }
        public string TrackingNumber { get; set; }
        public int DocumentAdditionalDataId { get; set; }
    }
}

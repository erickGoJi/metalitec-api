using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportSitetransfer
    {
        public int SiteTransferId { get; set; }
        public string SiteTransfer { get; set; }
        public string SiteTransferDescription { get; set; }
        public DateTime SiteTransferDate { get; set; }
        public byte Complete { get; set; }
        public string SiteReference { get; set; }
        public string ItemLocation { get; set; }
        public string ShippingAgent { get; set; }
        public string SiteTransferNotes { get; set; }
    }
}

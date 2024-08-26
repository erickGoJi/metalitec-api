using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportLocationtransfer
    {
        public int LocationTransferId { get; set; }
        public string LocationTransfer { get; set; }
        public string LocationTransferDescription { get; set; }
        public DateTime LocationTransferDate { get; set; }
        public byte Complete { get; set; }
        public string ItemLocation { get; set; }
        public string YardReference { get; set; }
        public string ShippingAgent { get; set; }
        public string LocationTransferNotes { get; set; }
    }
}

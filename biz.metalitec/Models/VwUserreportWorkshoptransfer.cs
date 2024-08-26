using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportWorkshoptransfer
    {
        public int WorkshopTransferId { get; set; }
        public string WorkshopTransfer { get; set; }
        public string WorkshopTransferDescription { get; set; }
        public DateTime WorkshopTransferDate { get; set; }
        public byte Complete { get; set; }
        public string ShopReference { get; set; }
        public string ItemLocation { get; set; }
        public string ShippingAgent { get; set; }
        public string WorkshopTransferNotes { get; set; }
    }
}

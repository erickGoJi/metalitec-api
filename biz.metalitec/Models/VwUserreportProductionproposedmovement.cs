using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportProductionproposedmovement
    {
        public int ProductionDeliveryNoteId { get; set; }
        public string ProductionDeliveryNote { get; set; }
        public string ProductionDeliveryNoteDescription { get; set; }
        public string Status { get; set; }
        public string ItemLocationType { get; set; }
        public string ItemLocation { get; set; }
        public string Employee { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Trailer { get; set; }
        public string ShippingAgent { get; set; }
        public int? Timbers { get; set; }
        public string ProductionDeliveryNoteNotes { get; set; }
    }
}

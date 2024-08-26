using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportProductionproposedmovementitem
    {
        public int ProductionDeliveryNoteItemId { get; set; }
        public int ProductionDeliveryNoteId { get; set; }
        public int ProductionWorkOrderId { get; set; }
        public int? ProductionWorkOrderContractId { get; set; }
        public string FromProductionProcess { get; set; }
        public string ToProductionProcess { get; set; }
        public double Quantity { get; set; }
        public string ProductionDeliveryNoteItemNotes { get; set; }
    }
}

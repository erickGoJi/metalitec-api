using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportReceivefromworkorder
    {
        public int ReceiveFromWorkOrderId { get; set; }
        public string ReceiveFromWorkOrder { get; set; }
        public string ReceiveFromWorkOrderDescription { get; set; }
        public DateTime ReceiveFromWorkOrderDate { get; set; }
        public byte Complete { get; set; }
        public double? Quantity { get; set; }
        public string ReceiveFromWorkOrderNotes { get; set; }
    }
}

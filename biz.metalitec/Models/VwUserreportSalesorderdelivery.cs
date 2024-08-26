using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportSalesorderdelivery
    {
        public int SalesOrderDeliveryId { get; set; }
        public string SalesOrderDelivery { get; set; }
        public string SalesOrderDeliveryDescription { get; set; }
        public DateTime SalesOrderDeliveryDate { get; set; }
        public byte Complete { get; set; }
        public int? CustomerId { get; set; }
        public string Customer { get; set; }
        public int? SalesOrderId { get; set; }
        public string SalesOrder { get; set; }
        public string SalesOrderDescription { get; set; }
        public bool SalesInvoiced { get; set; }
        public string SalesOrderDeliveryNotes { get; set; }
    }
}

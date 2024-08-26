using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportIteminventorytransaction
    {
        public int TransactionId { get; set; }
        public string Transaction { get; set; }
        public string TransactionDescription { get; set; }
        public string TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public byte Complete { get; set; }
        public int? SupplierId { get; set; }
        public string Supplier { get; set; }
        public int? CustomerId { get; set; }
        public string Customer { get; set; }
        public string ExternalReference { get; set; }
        public string ItemLocation { get; set; }
        public string YardReference { get; set; }
        public string ItemClassification { get; set; }
        public string PriceUnit { get; set; }
        public string CastReference { get; set; }
        public string TrackingNumber { get; set; }
        public int? ContractId { get; set; }
        public string Contract { get; set; }
        public string Phase { get; set; }
        public int? ContractMarkId { get; set; }
        public string Mark { get; set; }
        public int? ProductionWorkOrderId { get; set; }
        public string WorkOrder { get; set; }
        public string ShippingAgent { get; set; }
        public string AdjustmentType { get; set; }
        public int? SalesOrderId { get; set; }
        public string SalesOrder { get; set; }
        public string SalesOrderDescription { get; set; }
        public bool SalesInvoiced { get; set; }
        public int? EmployeeId { get; set; }
        public string Employee { get; set; }
        public string TransactionNotes { get; set; }
    }
}

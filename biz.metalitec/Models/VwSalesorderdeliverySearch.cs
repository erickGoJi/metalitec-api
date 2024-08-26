using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwSalesorderdeliverySearch
    {
        public int TransactionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? CustomerId { get; set; }
        public string Customer { get; set; }
        public int? SalesOrderId { get; set; }
        public string SalesOrderName { get; set; }
        public string StorageLocation { get; set; }
        public string SalesOrderType { get; set; }
        public string SalesOrderStatus { get; set; }
        public byte Complete { get; set; }
        public bool SalesInvoiced { get; set; }
        public int? ContractId { get; set; }
        public string Contract { get; set; }
    }
}

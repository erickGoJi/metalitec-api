using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwSalesorderSearch
    {
        public int SalesOrderId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public string CustomerReference { get; set; }
        public int LocationId { get; set; }
        public string StorageLocation { get; set; }
        public int? CurrencyId { get; set; }
        public string Currency { get; set; }
        public DateTime? ExchangeRateDate { get; set; }
        public double? ExchangeRate { get; set; }
        public int StatusId { get; set; }
        public string SalesOrderStatus { get; set; }
        public int? PaymentTermsId { get; set; }
        public string PaymentTerms { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public double? OrderValue { get; set; }
        public double? Weight { get; set; }
        public double? OrderQuantity { get; set; }
        public double? DeliveredQuantity { get; set; }
        public double? InvoicedQuantity { get; set; }
        public string SalesOrderType { get; set; }
        public int SalesOrderTypeId { get; set; }
        public string EdibatchNo { get; set; }
        public string Contract { get; set; }
        public string Facility { get; set; }
        public int? FacilityId { get; set; }
    }
}

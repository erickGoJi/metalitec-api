using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwPurchaseorderSearch
    {
        public int PurchaseOrderId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int SupplierId { get; set; }
        public string Supplier { get; set; }
        public string SupplierReference { get; set; }
        public int? EdiAmendment { get; set; }
        public string EdiAcknowledgement { get; set; }
        public string RequisitionNumber { get; set; }
        public int FacilityId { get; set; }
        public string Facility { get; set; }
        public int LocationId { get; set; }
        public int? PodeliveryAddressId { get; set; }
        public string PoDeliveryAddress { get; set; }
        public int? LineDeliveryAddressId { get; set; }
        public string LineDeliveryAddress { get; set; }
        public int? LineItemLocationTypeId { get; set; }
        public string PoDeliveryLocation { get; set; }
        public string LineDeliveryLocation { get; set; }
        public int? ItemLocationTypeId { get; set; }
        public int CurrencyId { get; set; }
        public string Currency { get; set; }
        public DateTime? ExchangeRateDate { get; set; }
        public double? ExchangeRate { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public int? PaymentTermsId { get; set; }
        public string PaymentTerms { get; set; }
        public double? OrderValue { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public double? OrderQuantity { get; set; }
        public double? ReceivedQuantity { get; set; }
        public double QuantityOutstanding { get; set; }
        public double? InvoicedQuantity { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool Exported { get; set; }
        public string ExportedBy { get; set; }
        public DateTime? ExportedOn { get; set; }
        public int Version { get; set; }
    }
}

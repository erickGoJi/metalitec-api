using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwIteminventorytransactionsSearch
    {
        public int TransactionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemTransactionTypeId { get; set; }
        public DateTime Date { get; set; }
        public byte Complete { get; set; }
        public byte? Isintoinventory { get; set; }
        public int? Sequence { get; set; }
        public int? LineTypeId { get; set; }
        public int? ItemId { get; set; }
        public int? MarkId { get; set; }
        public int? ItemLocationId { get; set; }
        public string YardReference { get; set; }
        public int? ItemClassificationId { get; set; }
        public int? CostCodeId { get; set; }
        public string CastReference { get; set; }
        public string TrackingNumber { get; set; }
        public int? SupplierId { get; set; }
        public string Supplier { get; set; }
        public string PurchaseOrder { get; set; }
        public string Receipt { get; set; }
        public double? Quantity { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public double? UnitPrice { get; set; }
        public int? UnitId { get; set; }
        public double? Value { get; set; }
        public int? ItemReservationId { get; set; }
        public int? PurchaseOrderItemId { get; set; }
        public byte? ReceivedInFull { get; set; }
        public byte? RetainOrderedValue { get; set; }
        public double? FreightCharge { get; set; }
        public double? Surcharge { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public int? ContractId { get; set; }
        public int? PhaseId { get; set; }
        public string Allocation { get; set; }
    }
}

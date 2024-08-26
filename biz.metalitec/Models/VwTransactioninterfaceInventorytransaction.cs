using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwTransactioninterfaceInventorytransaction
    {
        public int Id { get; set; }
        public int LineId { get; set; }
        public string Transaction { get; set; }
        public int ItemTransactionTypeId { get; set; }
        public byte Isintoinventory { get; set; }
        public int? Sequence { get; set; }
        public int? LineTypeId { get; set; }
        public string Item { get; set; }
        public string MarkItem { get; set; }
        public string ItemLocation { get; set; }
        public string YardReference { get; set; }
        public string ItemClassification { get; set; }
        public int? UnitId { get; set; }
        public int? BaseUnitId { get; set; }
        public double? BaseUnitConversion { get; set; }
        public string Unit { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double Value { get; set; }
        public byte Complete { get; set; }
        public string PurchaseOrder { get; set; }
        public byte? ReceivedInFull { get; set; }
        public byte? RetainOrderedValue { get; set; }
        public double? FreightCharge { get; set; }
        public double? Surcharge { get; set; }
        public byte IsNonStock { get; set; }
        public int? FacilityId { get; set; }
        public byte? ReversalStatus { get; set; }
        public string SalesOrder { get; set; }
        public string PurchaseOrderReceipt { get; set; }
        public string CastReference { get; set; }
        public string CostCode { get; set; }
        public string CostCentre { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string TrackingNumber { get; set; }
        public string Allocation { get; set; }
        public string Project { get; set; }
        public string Contract { get; set; }
        public int? ContractId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? OutLink { get; set; }
        public int? ItemId { get; set; }
        public string GradeName { get; set; }
        public int? ItemTypeId { get; set; }
        public string Section { get; set; }
        public string SectionCode { get; set; }
        public byte? Linear { get; set; }
        public string ItemName { get; set; }
        public string ItemActualName { get; set; }
        public string ItemAltName { get; set; }
        public int? PurchaseOrderId { get; set; }
        public string ItemInventoryTrackingGuidId { get; set; }
        public int? PurchaseOrderItemId { get; set; }
    }
}

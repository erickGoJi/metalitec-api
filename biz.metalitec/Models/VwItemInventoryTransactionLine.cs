using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwItemInventoryTransactionLine
    {
        public int TransActionLineId { get; set; }
        public int TransactionId { get; set; }
        public int ItemTransactionTypeId { get; set; }
        public byte Isintoinventory { get; set; }
        public int? Sequence { get; set; }
        public int? LineTypeId { get; set; }
        public int? ItemId { get; set; }
        public int? MarkId { get; set; }
        public int? MarkItemId { get; set; }
        public int? ContractMarkPhaseLotId { get; set; }
        public int? ContractMarkPhaseLotItemId { get; set; }
        public int? ItemLocationId { get; set; }
        public string YardReference { get; set; }
        public int? ItemClassificationId { get; set; }
        public int? UnitId { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double Value { get; set; }
        public byte Complete { get; set; }
        public int? PurchaseOrderItemId { get; set; }
        public byte? ReceivedInFull { get; set; }
        public byte? RetainOrderedValue { get; set; }
        public double? FreightCharge { get; set; }
        public double? Surcharge { get; set; }
        public int? ItemReservationId { get; set; }
        public int? LinkId { get; set; }
        public byte IsNonStock { get; set; }
        public byte? ReversalStatus { get; set; }
        public int? ReversalTransActionLineId { get; set; }
        public int? SalesOrderItemId { get; set; }
        public int? ItemInventoryShapeId { get; set; }
        public int? ProductionWorkOrderId { get; set; }
        public int? ProductionWorkOrderContractId { get; set; }
        public int? ItemInventoryPropertyId { get; set; }
        public int? NestingResultAllocationId { get; set; }
        public int? NestingResultItemListingId { get; set; }
        public int? CostCodeId { get; set; }
        public int? SupplierId { get; set; }
        public string PurchaseOrder { get; set; }
        public string Receipt { get; set; }
        public string CastReference { get; set; }
        public string TrackingNumber { get; set; }
        public string Cemark { get; set; }
    }
}

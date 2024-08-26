using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestingResultAllocationArchive
    {
        public int NestingResultAllocationId { get; set; }
        public int NestResultId { get; set; }
        public int ItemId { get; set; }
        public double Quantity { get; set; }
        public double Length { get; set; }
        public double? Width { get; set; }
        public double WasteLength { get; set; }
        public double WasteArea { get; set; }
        public double? SawWaste { get; set; }
        public double? OffcutLength { get; set; }
        public double? OffcutWidth { get; set; }
        public double? OffcutArea { get; set; }
        public int? SupplierId { get; set; }
        public int? PurchaseOrderItemId { get; set; }
        public int? ItemInventoryId { get; set; }
        public int? NestingResultSupplyLengthId { get; set; }
        public int? ItemReservationId { get; set; }
        public int? OffcutItemInventoryShapeId { get; set; }
        public int? LinkId { get; set; }
        public double QuantityCut { get; set; }
        public double QuantityReceived { get; set; }
        public bool PartialCut { get; set; }
        public byte? Status { get; set; }
        public string Notes { get; set; }
        public bool Accept { get; set; }
        public int? StockId { get; set; }
        public int? AlternateItemId { get; set; }
        public bool IsWeldedBar { get; set; }
        public int? WeldedBarNestingResultAllocationId { get; set; }
        public double? SawWasteArea { get; set; }
        public byte? NestingEngine { get; set; }
        public int? Tmpkey { get; set; }
        public double? EstimateCuttingTime { get; set; }
        public string Nraaux1 { get; set; }
        public string Nraaux2 { get; set; }
        public string Nraaux3 { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? DeliveryLocationId { get; set; }
        public int? ItemInventoryTrackingGuidid { get; set; }
        public string NestEngineBarReference { get; set; }
        public string NestEngineTask { get; set; }
        public string NestEngineUsed { get; set; }
        public string NestEngineWorkspace { get; set; }
        public int? DeliveryAddressId { get; set; }
        public bool? DetailNested { get; set; }
        public int? NestType { get; set; }

        public virtual ItemReservation ItemReservation { get; set; }
        public virtual ItemInventoryShape OffcutItemInventoryShape { get; set; }
    }
}

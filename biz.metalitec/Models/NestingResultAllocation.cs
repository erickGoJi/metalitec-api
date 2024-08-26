using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestingResultAllocation
    {
        public NestingResultAllocation()
        {
            NestingResultItemListings = new HashSet<NestingResultItemListing>();
        }

        public int NestingResultAllocationId { get; set; }
        /// <summary>
        /// Header link
        /// </summary>
        public int NestResultId { get; set; }
        public int ItemId { get; set; }
        public double Quantity { get; set; }
        /// <summary>
        /// Used to link the NRA table to the NRI table when inserting - donot use otherwise!
        /// </summary>
        public int? StockId { get; set; }
        public double Length { get; set; }
        /// <summary>
        /// ~--DELETE--ItemReservationID handels the link maybe good for tracking!!!
        /// </summary>
        public int? PurchaseOrderItemId { get; set; }
        /// <summary>
        /// ~--Delete?
        /// </summary>
        public int? SupplierId { get; set; }
        /// <summary>
        /// ~ Delete???
        /// </summary>
        public int? ItemInventoryId { get; set; }
        public int? ItemReservationId { get; set; }
        public int? LinkId { get; set; }
        public double? Width { get; set; }
        /// <summary>
        /// Jsut for development/testing - Remove!
        /// </summary>
        public int? AlternateItemId { get; set; }
        public double QuantityCut { get; set; }
        public double QuantityReceived { get; set; }
        public string Notes { get; set; }
        public double WasteLength { get; set; }
        public double WasteArea { get; set; }
        public double? SawWaste { get; set; }
        public double? OffcutLength { get; set; }
        public double? OffcutWidth { get; set; }
        public double? OffcutArea { get; set; }
        /// <summary>
        /// On a saved nest this is the pointer to where the material will come from
        /// </summary>
        public int? NestingResultSupplyLengthId { get; set; }
        /// <summary>
        /// The shape of the offcut for plate nesting
        /// </summary>
        public int? OffcutItemInventoryShapeId { get; set; }
        /// <summary>
        /// 0 - Saved, 1 - Allocated/Completed
        /// </summary>
        public byte? Status { get; set; }
        /// <summary>
        /// If the bar/plate used on the nest is accepted on the current nest - maybe just do not save is not accepted...
        /// </summary>
        public bool? Accept { get; set; }
        public bool PartialCut { get; set; }
        /// <summary>
        /// If the bar is made up of smaller parts
        /// </summary>
        public bool IsWeldedBar { get; set; }
        /// <summary>
        /// The bar that will be created when this bar is welded to other pieces
        /// </summary>
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
        /// <summary>
        /// A nesting engine internal reference for ththis specific bar
        /// </summary>
        public string NestEngineBarReference { get; set; }
        /// <summary>
        /// A nesting engine internal reference for the nest job this bar is part of
        /// </summary>
        public string NestEngineTask { get; set; }
        /// <summary>
        /// The nesting engine used to nest this bar
        /// </summary>
        public string NestEngineUsed { get; set; }
        /// <summary>
        /// A nesting engine internal reference for the nest this bar is part of
        /// </summary>
        public string NestEngineWorkspace { get; set; }
        public int? DeliveryAddressId { get; set; }
        public bool? DetailNested { get; set; }
        public int? NestType { get; set; }

        public virtual ItemReservation ItemReservation { get; set; }
        public virtual NestingResultSupplyLength NestingResultSupplyLength { get; set; }
        public virtual ItemInventoryShape OffcutItemInventoryShape { get; set; }
        public virtual ICollection<NestingResultItemListing> NestingResultItemListings { get; set; }
    }
}

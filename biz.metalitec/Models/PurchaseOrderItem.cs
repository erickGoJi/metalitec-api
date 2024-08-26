using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PurchaseOrderItem
    {
        public PurchaseOrderItem()
        {
            NestingResultSupplyLengthArchives = new HashSet<NestingResultSupplyLengthArchive>();
            NestingResultSupplyLengths = new HashSet<NestingResultSupplyLength>();
            PurchaseOrderItemInstances = new HashSet<PurchaseOrderItemInstance>();
        }

        /// <summary>
        /// Unique ID automatically generated
        /// </summary>
        public int PurchaseOrderItemId { get; set; }
        /// <summary>
        /// The ID of the Purchase Order
        /// </summary>
        public int PurchaseOrderId { get; set; }
        /// <summary>
        /// The type of line
        /// </summary>
        public int LineTypeId { get; set; }
        /// <summary>
        /// ~1 - User, 2 - Nesting
        /// </summary>
        public int Source { get; set; }
        /// <summary>
        /// The line description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The Item that must be ordered
        /// </summary>
        public int? ItemId { get; set; }
        /// <summary>
        /// The length that must be ordered if the item has a length
        /// </summary>
        public double Length { get; set; }
        /// <summary>
        /// The width that must be ordered if the item has a width
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// The total weight that is ordered
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// The total area that is ordered
        /// </summary>
        public double Area { get; set; }
        /// <summary>
        /// The part number that your supplier uses for this item
        /// </summary>
        public string SupplierPartNumber { get; set; }
        /// <summary>
        /// The agreed delivery date of this item
        /// </summary>
        public DateTime DeliveryDate { get; set; }
        /// <summary>
        /// The location where this item will be delivered to
        /// </summary>
        public int ItemLocationId { get; set; }
        public string YardReference { get; set; }
        public int? RollReferenceLineId { get; set; }
        /// <summary>
        /// The Cost Code of the Item
        /// </summary>
        public int CostCodeId { get; set; }
        /// <summary>
        /// The quantity ordered
        /// </summary>
        public double OrderQuantity { get; set; }
        /// <summary>
        /// the quantity that has been received for this item
        /// </summary>
        public double ReceivedQuantity { get; set; }
        /// <summary>
        /// Has this item been received in full
        /// </summary>
        public bool ReceivedinFull { get; set; }
        public int UnitId { get; set; }
        /// <summary>
        /// The unit price in the ordering currency
        /// </summary>
        public double OriginalUnitPrice { get; set; }
        /// <summary>
        /// The unit price in the system currency
        /// </summary>
        public double UnitPrice { get; set; }
        /// <summary>
        /// the percent discount for this item
        /// </summary>
        public double? DiscountPercent { get; set; }
        /// <summary>
        /// The discount amount in ordering currency
        /// </summary>
        public double OriginalDiscountValue { get; set; }
        /// <summary>
        /// The discount amount in the system currency
        /// </summary>
        public double DiscountValue { get; set; }
        /// <summary>
        /// The tax code to use to get the tax percent
        /// </summary>
        public int? TaxCodeId { get; set; }
        /// <summary>
        /// The tax percent to use to calculate the tax amount
        /// </summary>
        public double TaxPercent { get; set; }
        /// <summary>
        /// The tax amount in the ordering currency
        /// </summary>
        public double OriginalTaxValue { get; set; }
        /// <summary>
        /// The tax amount in the system currency
        /// </summary>
        public double TaxValue { get; set; }
        /// <summary>
        /// The net amount after discount and tax in the ordering currency
        /// </summary>
        public double OriginalValue { get; set; }
        /// <summary>
        /// The net amount after discount and tax in the system currency
        /// </summary>
        public double Value { get; set; }
        public int? ItemReservationId { get; set; }
        public string Notes { get; set; }
        public int? LineNumber { get; set; }
        public bool IsDirectIssue { get; set; }
        public int? InvoicedQuantity { get; set; }
        public DateTime? RollReferenceDate { get; set; }
        /// <summary>
        /// The multiples in which the item is purchased
        /// </summary>
        public int OrderUnitId { get; set; }
        /// <summary>
        /// Purchase Order Line Automatically created to account for minimum order quantity/order multiple
        /// </summary>
        public bool MinQuantityExcessLine { get; set; }
        public bool? CadweightArea { get; set; }
        public double? Cambering { get; set; }
        public int? DeliveryAddressId { get; set; }
        public double? Radius { get; set; }

        public virtual CostCode CostCode { get; set; }
        public virtual Address DeliveryAddress { get; set; }
        public virtual Item Item { get; set; }
        public virtual ItemLocation ItemLocation { get; set; }
        public virtual ItemReservation ItemReservation { get; set; }
        public virtual Unit OrderUnit { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual RollReferenceLine RollReferenceLine { get; set; }
        public virtual TaxCode TaxCode { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ICollection<NestingResultSupplyLengthArchive> NestingResultSupplyLengthArchives { get; set; }
        public virtual ICollection<NestingResultSupplyLength> NestingResultSupplyLengths { get; set; }
        public virtual ICollection<PurchaseOrderItemInstance> PurchaseOrderItemInstances { get; set; }
    }
}

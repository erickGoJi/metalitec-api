using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SalesOrderItem
    {
        public SalesOrderItem()
        {
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            SalesInvoiceItems = new HashSet<SalesInvoiceItem>();
            SalesOrderItemInstances = new HashSet<SalesOrderItemInstance>();
        }

        public int SalesOrderItemId { get; set; }
        public int SalesOrderId { get; set; }
        /// <summary>
        /// 1= Steel Item, 2 = Non-Steel Item, 3= Free Line Item
        /// </summary>
        public int LineTypeId { get; set; }
        public int Source { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// Item Ordered / Quoted
        /// </summary>
        public int? ItemId { get; set; }
        /// <summary>
        /// Length of Item Unit Ordered / Quoted
        /// </summary>
        public double Length { get; set; }
        /// <summary>
        /// Width of Item Unit Ordered / Quoted
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// Weight of Item Unit Ordered / Quoted
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Area of Item Unit Ordered / Quoted
        /// </summary>
        public double Area { get; set; }
        /// <summary>
        /// Customers Part Number / Reference (Defaults to Item Customer Part Number)
        /// </summary>
        public string CustomerPartNumber { get; set; }
        /// <summary>
        /// Date to be Delivered (Defaults to Sales Order Delivery Date)
        /// </summary>
        public DateTime DeliveryDate { get; set; }
        /// <summary>
        /// Storage Location that the Goods were delivered from (Defaults to Sales Order Header Location)
        /// </summary>
        public int? ItemLocationId { get; set; }
        /// <summary>
        /// Cost Code (Defaults to Item Cost Code)
        /// </summary>
        public int CostCodeId { get; set; }
        /// <summary>
        /// Quantity Ordered
        /// </summary>
        public double OrderQuantity { get; set; }
        /// <summary>
        /// Quantity Delivered
        /// </summary>
        public double DeliveredQuantity { get; set; }
        /// <summary>
        /// If the Sales Order has been delivered in Full
        /// </summary>
        public byte DeliveredInFull { get; set; }
        /// <summary>
        /// Sales Price Unit of Measure  (Defaults to Item Customer Unit)
        /// </summary>
        public int UnitId { get; set; }
        /// <summary>
        /// Unit Price in Document Currency
        /// </summary>
        public double OriginalUnitPrice { get; set; }
        /// <summary>
        /// Unit Price in Local Currency Value
        /// </summary>
        public double UnitPrice { get; set; }
        /// <summary>
        /// Discount Percentage (Defaults to Item Customer Discount)
        /// </summary>
        public double? DiscountPercent { get; set; }
        /// <summary>
        /// Discount Value in Document Currency Value
        /// </summary>
        public double OriginalDiscountValue { get; set; }
        /// <summary>
        /// Discount Value in System Currency
        /// </summary>
        public double DiscountValue { get; set; }
        /// <summary>
        /// FK Tax Code (Defaults to Item Customer Tax Code)
        /// </summary>
        public int? TaxCodeId { get; set; }
        /// <summary>
        /// Tax Percentage
        /// </summary>
        public double TaxPercent { get; set; }
        /// <summary>
        /// Tax Value in Document Currency Value
        /// </summary>
        public double OriginalTaxValue { get; set; }
        /// <summary>
        /// Tax Value in System Currency
        /// </summary>
        public double TaxValue { get; set; }
        /// <summary>
        /// Total Item Value in Document Currency Value
        /// </summary>
        public double OriginalValue { get; set; }
        /// <summary>
        /// Total Item Value in System Currency
        /// </summary>
        public double Value { get; set; }
        public int? ItemReservationId { get; set; }
        /// <summary>
        /// Allows user notes or predefined notes
        /// </summary>
        public string Notes { get; set; }
        public int? LineNumber { get; set; }
        public double QuantityToDeliver { get; set; }
        /// <summary>
        /// Quantity Delivered and Invoiced
        /// </summary>
        public double InvoicedQuantity { get; set; }
        /// <summary>
        /// The Invoice Schedule to Associate to the Contract assigned in the Sales Order Header
        /// </summary>
        public int? ContractInvoiceScheduleId { get; set; }
        /// <summary>
        /// Used as a guide to populate select the Inventory for the Delivery.
        /// </summary>
        public int? SuggestedItemInventoryId { get; set; }
        public int? PhaseId { get; set; }
        public int? ContractId { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual ContractInvoiceSchedule ContractInvoiceSchedule { get; set; }
        public virtual ItemReservation ItemReservation { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<SalesInvoiceItem> SalesInvoiceItems { get; set; }
        public virtual ICollection<SalesOrderItemInstance> SalesOrderItemInstances { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SalesInvoiceItem
    {
        public SalesInvoiceItem()
        {
            SalesInvoiceItemInstances = new HashSet<SalesInvoiceItemInstance>();
        }

        public int SalesInvoiceItemId { get; set; }
        /// <summary>
        /// FK SalesInvoice.SalesInvoiceID
        /// </summary>
        public int SalesInvoiceId { get; set; }
        /// <summary>
        /// The Source SalesInvoiceLineID
        /// </summary>
        public int? SalesOrderItemId { get; set; }
        /// <summary>
        /// The Source Inventory Transaction LineID
        /// </summary>
        public int? TransActionLineId { get; set; }
        /// <summary>
        /// 1= Steel Item, 2 = Non-Steel Item, 3= Free Line Item
        /// </summary>
        public int LineTypeId { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// Item Invoiced
        /// </summary>
        public int? ItemId { get; set; }
        /// <summary>
        /// Length of Item Unit Invoiced
        /// </summary>
        public double Length { get; set; }
        /// <summary>
        /// Width of Item Unit Invoiced
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// Weight of Item Unit Invoiced
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Area of Item Unit Invoiced
        /// </summary>
        public double Area { get; set; }
        /// <summary>
        /// Customers Part Number / Reference (Defaults to Item Customer Part Number)
        /// </summary>
        public string CustomerPartNumber { get; set; }
        /// <summary>
        /// Actual Date of the Delivery Document
        /// </summary>
        public DateTime? DeliveryDate { get; set; }
        /// <summary>
        /// Storage Location that the Goods were delivered from
        /// </summary>
        public int? ItemLocationId { get; set; }
        /// <summary>
        /// Cost Code
        /// </summary>
        public int CostCodeId { get; set; }
        /// <summary>
        /// Quantity to Invoice
        /// </summary>
        public double InvoicedQuantity { get; set; }
        /// <summary>
        /// If the Sales Order was delivered in Full
        /// </summary>
        public byte DeliveredInFull { get; set; }
        /// <summary>
        /// Sales Price Unit of Measure
        /// </summary>
        public int UnitId { get; set; }
        /// <summary>
        /// Unit Price in Document Currency Value
        /// </summary>
        public double OriginalUnitPrice { get; set; }
        /// <summary>
        /// Unit Price in System Currency
        /// </summary>
        public double UnitPrice { get; set; }
        /// <summary>
        /// Discount Percentage
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
        /// <summary>
        /// Allows user notes or predefined notes (defaults to the Notes from the)
        /// </summary>
        public string Notes { get; set; }
        public int? LineNumber { get; set; }
        public int? ContractId { get; set; }
        public int? ContractInvoiceScheduleId { get; set; }
        public int? ContractMarkPhaseLotId { get; set; }
        public int? MarkId { get; set; }
        public int? QsanalysisCategoryId { get; set; }
        public int? ApplicationForPaymentAgreedItemId { get; set; }
        public int? ChangeOrderId { get; set; }
        public double CompletionValue { get; set; }
        public bool IsRetentionClaim { get; set; }
        public double MaterialsStoredValue { get; set; }
        public double RetentionValue { get; set; }
        public string TransactionId { get; set; }

        public virtual ApplicationForPaymentAgreedItem ApplicationForPaymentAgreedItem { get; set; }
        public virtual ChangeOrder ChangeOrder { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual ContractInvoiceSchedule ContractInvoiceSchedule { get; set; }
        public virtual ContractMarkPhaseLot ContractMarkPhaseLot { get; set; }
        public virtual QsanalysisCategory QsanalysisCategory { get; set; }
        public virtual SalesInvoice SalesInvoice { get; set; }
        public virtual SalesOrderItem SalesOrderItem { get; set; }
        public virtual ItemInventoryTransactionLine TransActionLine { get; set; }
        public virtual ICollection<SalesInvoiceItemInstance> SalesInvoiceItemInstances { get; set; }
    }
}

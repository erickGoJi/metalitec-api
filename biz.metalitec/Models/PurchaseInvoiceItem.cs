using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PurchaseInvoiceItem
    {
        public PurchaseInvoiceItem()
        {
            PurchaseInvoiceItemContracts = new HashSet<PurchaseInvoiceItemContract>();
            PurchaseInvoiceItemInstances = new HashSet<PurchaseInvoiceItemInstance>();
        }

        public int PurchaseInvoiceItemId { get; set; }
        /// <summary>
        /// The Source PurchaseInvoiceID
        /// </summary>
        public int PurchaseInvoiceId { get; set; }
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
        /// Suppliers Part Number / Reference (Defaults to Item Supplier Part Number)
        /// </summary>
        public string SupplierPartNumber { get; set; }
        /// <summary>
        /// Quantity On Invoice
        /// </summary>
        public double InvoicedQuantity { get; set; }
        /// <summary>
        /// Cost Code
        /// </summary>
        public int CostCodeId { get; set; }
        /// <summary>
        /// Purchase Price Unit of Measure
        /// </summary>
        public int UnitId { get; set; }
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
        /// <summary>
        /// The Purchase Order Receipt Line ID that the Invoice corresponds to
        /// </summary>
        public int? TransActionLineId { get; set; }
        public double OriginalUnitPrice { get; set; }
        /// <summary>
        /// The Contract this Purchase Invoice Line Belongs
        /// </summary>
        public int? ContractId { get; set; }
        /// <summary>
        /// The multiples in which the item is purchased
        /// </summary>
        public int OrderUnitId { get; set; }
        public int? AdditionId { get; set; }

        public virtual Addition Addition { get; set; }
        public virtual PurchaseInvoice PurchaseInvoice { get; set; }
        public virtual ItemInventoryTransactionLine TransActionLine { get; set; }
        public virtual PurchaseInvoiceCreditItem PurchaseInvoiceCreditItem { get; set; }
        public virtual ICollection<PurchaseInvoiceItemContract> PurchaseInvoiceItemContracts { get; set; }
        public virtual ICollection<PurchaseInvoiceItemInstance> PurchaseInvoiceItemInstances { get; set; }
    }
}

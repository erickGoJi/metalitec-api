using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemSupplier
    {
        public ItemSupplier()
        {
            ItemSupplierLengths = new HashSet<ItemSupplierLength>();
            RollReferenceItems = new HashSet<RollReferenceItem>();
        }

        public int ItemSupplierId { get; set; }
        public int ItemId { get; set; }
        public int SupplierId { get; set; }
        /// <summary>
        /// The part number that the supplier uses for the item
        /// </summary>
        public string SupplierPartNumber { get; set; }
        /// <summary>
        /// Is this the default supplier for the item
        /// </summary>
        public byte? DefaultSupplier { get; set; }
        /// <summary>
        /// The unit price of the item
        /// </summary>
        public double UnitPrice { get; set; }
        /// <summary>
        /// The unit to use when determining the price of the item
        /// </summary>
        public int? PriceUnitId { get; set; }
        /// <summary>
        /// The currency used for the unit price
        /// </summary>
        public int CurrencyId { get; set; }
        /// <summary>
        /// The tax code that must be used when ordering this item
        /// </summary>
        public int? TaxCodeId { get; set; }
        /// <summary>
        /// The default discount percent when ordering the item
        /// </summary>
        public double Discount { get; set; }
        public int? MillLocationId { get; set; }
        public int? Leadtime { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        public double MinOrderQuantity { get; set; }
        public double OrderMultiple { get; set; }
        public string SupplierPartCode { get; set; }
        public string SupplierPartGrade { get; set; }
        public string SupplierPartSize { get; set; }
        public string SupplierRollReferenceSerial { get; set; }
        public int? ContractId { get; set; }

        public virtual Item Item { get; set; }
        public virtual Unit PriceUnit { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual TaxCode TaxCode { get; set; }
        public virtual ICollection<ItemSupplierLength> ItemSupplierLengths { get; set; }
        public virtual ICollection<RollReferenceItem> RollReferenceItems { get; set; }
    }
}

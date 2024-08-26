using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemCustomer
    {
        public int ItemCustomerId { get; set; }
        public int ItemId { get; set; }
        public int CustomerId { get; set; }
        /// <summary>
        /// The part number that the customer uses for the item
        /// </summary>
        public string CustomerPartNumber { get; set; }
        public string CustomerPartCode { get; set; }
        public string CustomerPartGrade { get; set; }
        public string CustomerPartSize { get; set; }
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
        public int? PaymentTermsId { get; set; }
        /// <summary>
        /// The default discount percent when ordering the item
        /// </summary>
        public double Discount { get; set; }
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

        public virtual Customer Customer { get; set; }
        public virtual Item Item { get; set; }
        public virtual Unit PriceUnit { get; set; }
        public virtual TaxCode TaxCode { get; set; }
    }
}

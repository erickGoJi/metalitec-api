using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Currency
    {
        public Currency()
        {
            AdditionTemplates = new HashSet<AdditionTemplate>();
            Additions = new HashSet<Addition>();
            CurrencyConversionFromCurrencies = new HashSet<CurrencyConversion>();
            CurrencyConversionToCurrencies = new HashSet<CurrencyConversion>();
            Customers = new HashSet<Customer>();
            Facilities = new HashSet<Facility>();
            ItemInventories = new HashSet<ItemInventory>();
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            ItemSiteInventories = new HashSet<ItemSiteInventory>();
            Suppliers = new HashSet<Supplier>();
        }

        /// <summary>
        /// The unique currency ID number generated automatically.
        /// </summary>
        public int CurrencyId { get; set; }
        /// <summary>
        /// Enter the currency name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Give the currency a description.
        /// </summary>
        public string Description { get; set; }
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
        public int Version { get; set; }
        public byte? System { get; set; }

        public virtual ICollection<AdditionTemplate> AdditionTemplates { get; set; }
        public virtual ICollection<Addition> Additions { get; set; }
        public virtual ICollection<CurrencyConversion> CurrencyConversionFromCurrencies { get; set; }
        public virtual ICollection<CurrencyConversion> CurrencyConversionToCurrencies { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<ItemSiteInventory> ItemSiteInventories { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}

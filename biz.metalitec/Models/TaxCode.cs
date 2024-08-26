using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class TaxCode
    {
        public TaxCode()
        {
            AdditionTemplates = new HashSet<AdditionTemplate>();
            Additions = new HashSet<Addition>();
            Customers = new HashSet<Customer>();
            ItemCustomers = new HashSet<ItemCustomer>();
            ItemSuppliers = new HashSet<ItemSupplier>();
            PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
            Suppliers = new HashSet<Supplier>();
        }

        /// <summary>
        /// Unique ID for the tax code
        /// </summary>
        public int TaxCodeId { get; set; }
        /// <summary>
        /// Name of the tax code
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the tax code
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// the percentage tax to use
        /// </summary>
        public double TaxPercentage { get; set; }
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
        public string ExternalReference { get; set; }

        public virtual ICollection<AdditionTemplate> AdditionTemplates { get; set; }
        public virtual ICollection<Addition> Additions { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<ItemCustomer> ItemCustomers { get; set; }
        public virtual ICollection<ItemSupplier> ItemSuppliers { get; set; }
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}

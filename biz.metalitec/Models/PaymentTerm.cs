using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class PaymentTerm
    {
        public PaymentTerm()
        {
            AdditionTemplates = new HashSet<AdditionTemplate>();
            Additions = new HashSet<Addition>();
            Customers = new HashSet<Customer>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            SalesOrders = new HashSet<SalesOrder>();
            Suppliers = new HashSet<Supplier>();
        }

        /// <summary>
        /// Unique ID for the payment term
        /// </summary>
        public int PaymentTermsId { get; set; }
        /// <summary>
        /// Name of payment term
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the payment term
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        public string Notes { get; set; }
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

        public virtual ICollection<AdditionTemplate> AdditionTemplates { get; set; }
        public virtual ICollection<Addition> Additions { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}

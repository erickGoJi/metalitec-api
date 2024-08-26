using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Contracts = new HashSet<Contract>();
            Edifiles = new HashSet<Edifile>();
            Enquiries = new HashSet<Enquiry>();
            ItemCustomers = new HashSet<ItemCustomer>();
            SalesInvoices = new HashSet<SalesInvoice>();
            SalesOrders = new HashSet<SalesOrder>();
        }

        /// <summary>
        /// The unique customer ID number generated automatically.
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// Enter customers name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Define the customer type.
        /// </summary>
        public int? CustomerTypeId { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public byte? System { get; set; }
        public string ExternalReference { get; set; }
        public int CurrencyId { get; set; }
        public int? TaxCodeId { get; set; }
        public int? PaymentTermsId { get; set; }
        public int? EdifileFormat { get; set; }
        public string Edireference { get; set; }
        public string Ediemail { get; set; }
        public string EdisubjectHeaderSuffix { get; set; }
        public int? EdiinterfaceOut { get; set; }
        public string Notes { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual TransactionInterface EdiinterfaceOutNavigation { get; set; }
        public virtual PaymentTerm PaymentTerms { get; set; }
        public virtual TaxCode TaxCode { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Edifile> Edifiles { get; set; }
        public virtual ICollection<Enquiry> Enquiries { get; set; }
        public virtual ICollection<ItemCustomer> ItemCustomers { get; set; }
        public virtual ICollection<SalesInvoice> SalesInvoices { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}

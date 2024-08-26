using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SalesOrder
    {
        public SalesOrder()
        {
            Edifiles = new HashSet<Edifile>();
            ItemInventoryTransactions = new HashSet<ItemInventoryTransaction>();
            SalesOrderItems = new HashSet<SalesOrderItem>();
        }

        public int SalesOrderId { get; set; }
        /// <summary>
        /// 1 = Sales Order (default), 2 = Sales Quotation, 3 = Contract Sales Order
        /// </summary>
        public int SalesOrderTypeId { get; set; }
        /// <summary>
        /// Specify a name for the Sales order
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the Sales order
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The date of the Sales order
        /// </summary>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// The Customer table foreign key
        /// </summary>
        public int CustomerId { get; set; }
        public int? CustomerAddressId { get; set; }
        /// <summary>
        /// The Customers&apos; reference for this order
        /// </summary>
        public string CustomerReference { get; set; }
        public string OrderTakenBy { get; set; }
        /// <summary>
        /// The default delivery location for the order
        /// </summary>
        public int ItemLocationId { get; set; }
        public DateTime? OrderDeliveryDate { get; set; }
        public int? OrderCategory { get; set; }
        /// <summary>
        /// The Currency table foreign key
        /// </summary>
        public int CurrencyId { get; set; }
        /// <summary>
        /// The date to use to retrieve the exchange rate
        /// </summary>
        public DateTime? ExchangeRateDate { get; set; }
        /// <summary>
        /// The exchange rate if it is a foreign currency
        /// </summary>
        public double? ExchangeRate { get; set; }
        /// <summary>
        /// The status of the order - 1 Preparation, 2 - Released, 3 - Closed
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// The Payment terms agreed with the Customer for this order
        /// </summary>
        public int? PaymentTermsId { get; set; }
        public int? TaxCodeId { get; set; }
        /// <summary>
        /// Allows user notes or predefined notes
        /// </summary>
        public string Notes { get; set; }
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
        /// <summary>
        /// Address to send Invoice to
        /// </summary>
        public int? CustomerBillingAddressId { get; set; }
        /// <summary>
        /// The Contract associated with the Sales Order
        /// </summary>
        public int? ContractId { get; set; }
        public int FacilityId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Address CustomerAddress { get; set; }
        public virtual Facility Facility { get; set; }
        public virtual PaymentTerm PaymentTerms { get; set; }
        public virtual ICollection<Edifile> Edifiles { get; set; }
        public virtual ICollection<ItemInventoryTransaction> ItemInventoryTransactions { get; set; }
        public virtual ICollection<SalesOrderItem> SalesOrderItems { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Address
    {
        public Address()
        {
            AdditionTemplates = new HashSet<AdditionTemplate>();
            Additions = new HashSet<Addition>();
            ItemInventoryTransactionLineArchives = new HashSet<ItemInventoryTransactionLineArchive>();
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            NestingResults = new HashSet<NestingResult>();
            ProductionContainers = new HashSet<ProductionContainer>();
            ProductionPackages = new HashSet<ProductionPackage>();
            PurchaseOrderDeliveryAddresses = new HashSet<PurchaseOrder>();
            PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
            PurchaseOrderSupplierAddresses = new HashSet<PurchaseOrder>();
            SalesOrders = new HashSet<SalesOrder>();
        }

        /// <summary>
        /// The unique Address ID number generated automatically.
        /// </summary>
        public int AddressId { get; set; }
        /// <summary>
        /// ~Address Type, 1=Contact, 2=Customer, 3=Supplier, 4=Location, 5=Enquiry, 6=Contract, 7=User, 8=Employee, 9=OffSite, 10=Facility,11=Delivery Note, 12=EnquiryProjectPeople
        /// </summary>
        public int AddressSourceTypeId { get; set; }
        /// <summary>
        /// Key to identify if the address is in the contact, customer, supplier and Proposed Movement tables.
        /// </summary>
        public int SourceKey { get; set; }
        /// <summary>
        /// Name of Address
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ~Address Line 1
        /// </summary>
        public string Line1 { get; set; }
        /// <summary>
        /// Address Line 2
        /// </summary>
        public string Line2 { get; set; }
        /// <summary>
        /// Address Line 3
        /// </summary>
        public string Line3 { get; set; }
        /// <summary>
        /// Address Line 4
        /// </summary>
        public string Line4 { get; set; }
        /// <summary>
        /// Zip or Postcode
        /// </summary>
        public string Postcode { get; set; }
        public int Version { get; set; }
        public string Country { get; set; }
        public bool? Default { get; set; }
        public byte ShowInOrdering { get; set; }

        public virtual ICollection<AdditionTemplate> AdditionTemplates { get; set; }
        public virtual ICollection<Addition> Additions { get; set; }
        public virtual ICollection<ItemInventoryTransactionLineArchive> ItemInventoryTransactionLineArchives { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<NestingResult> NestingResults { get; set; }
        public virtual ICollection<ProductionContainer> ProductionContainers { get; set; }
        public virtual ICollection<ProductionPackage> ProductionPackages { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrderDeliveryAddresses { get; set; }
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrderSupplierAddresses { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
    }
}

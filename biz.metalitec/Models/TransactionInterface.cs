using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class TransactionInterface
    {
        public TransactionInterface()
        {
            Customers = new HashSet<Customer>();
            SupplierEdiinterfaceInNavigations = new HashSet<Supplier>();
            SupplierEdiinterfaceOutNavigations = new HashSet<Supplier>();
            SupplierPoediinterfaceInNavigations = new HashSet<Supplier>();
            SupplierPoediinterfaceOutNavigations = new HashSet<Supplier>();
            SupplierRollReferenceInterfaceNavigations = new HashSet<Supplier>();
            TransactionInterfaceLogs = new HashSet<TransactionInterfaceLog>();
        }

        /// <summary>
        /// Transaction Interface Unique ID Number
        /// </summary>
        public int TransactionInterfaceId { get; set; }
        /// <summary>
        /// Name of the Transaction Interface
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the Transaction Interface
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Type of Transaction Interface
        /// </summary>
        public int TransactionInterfaceTypeId { get; set; }
        /// <summary>
        /// The extension of the file you wish to export
        /// </summary>
        public string FileExtension { get; set; }
        /// <summary>
        /// The file location of the accounting system company file
        /// </summary>
        public string TargetApplicationFileName { get; set; }
        /// <summary>
        /// The folder you wish to export the file to
        /// </summary>
        public string TargetFolder { get; set; }
        /// <summary>
        /// The file location of the accounting system
        /// </summary>
        public string ExecutableFileName { get; set; }
        /// <summary>
        /// The name of the user with permission to connect to the accounting system
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// The password of the user with permission to connect to the accounting system
        /// </summary>
        public string Password { get; set; }
        public string Script { get; set; }
        public string Notes { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public bool System { get; set; }
        /// <summary>
        /// Whether to shell the Transaction Interface to run as a 32-bit process on a 64-bit OS
        /// </summary>
        public bool RunAsX86 { get; set; }
        public int? CodeBaseId { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Supplier> SupplierEdiinterfaceInNavigations { get; set; }
        public virtual ICollection<Supplier> SupplierEdiinterfaceOutNavigations { get; set; }
        public virtual ICollection<Supplier> SupplierPoediinterfaceInNavigations { get; set; }
        public virtual ICollection<Supplier> SupplierPoediinterfaceOutNavigations { get; set; }
        public virtual ICollection<Supplier> SupplierRollReferenceInterfaceNavigations { get; set; }
        public virtual ICollection<TransactionInterfaceLog> TransactionInterfaceLogs { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionPackage
    {
        public ProductionPackage()
        {
            ProductionContainerItemArchives = new HashSet<ProductionContainerItemArchive>();
            ProductionContainerItems = new HashSet<ProductionContainerItem>();
            ProductionPackageItemArchives = new HashSet<ProductionPackageItemArchive>();
            ProductionPackageItems = new HashSet<ProductionPackageItem>();
            ProductionProposedMovementItemArchives = new HashSet<ProductionProposedMovementItemArchive>();
            ProductionProposedMovementItems = new HashSet<ProductionProposedMovementItem>();
        }

        /// <summary>
        /// The system ID of the Package.
        /// </summary>
        public int ProductionPackageId { get; set; }
        /// <summary>
        /// The system name of the Package.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Description of the Package.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The Type of the Package.
        /// </summary>
        public int ProductionPackageTypeId { get; set; }
        /// <summary>
        /// The Status of the Package.
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// The Faciltiy the Package is being dispatched from.
        /// </summary>
        public int? FacilityId { get; set; }
        /// <summary>
        /// The List Reference of the Package.
        /// </summary>
        public string List { get; set; }
        /// <summary>
        /// The Reference of the Package.
        /// </summary>
        public string Reference { get; set; }
        /// <summary>
        /// The Type of the Delivery Location.
        /// </summary>
        public int ItemLocationTypeId { get; set; }
        /// <summary>
        /// The Delivery Location.
        /// </summary>
        public int ItemLocationId { get; set; }
        /// <summary>
        /// The Delivery Address.
        /// </summary>
        public int? ItemLocationAddressId { get; set; }
        /// <summary>
        /// The dispatch date of the Package.
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// The length of the Package.
        /// </summary>
        public double Length { get; set; }
        /// <summary>
        /// The width of the Package.
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// The depth of the Package.
        /// </summary>
        public double Depth { get; set; }
        public double Weight { get; set; }
        /// <summary>
        /// Enter any additional notes you may wish to add about the Package.
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// The User who created the Package.
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Date the Package was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The last User to update the Package.
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// Date the Package was last updated.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public int? TransactionId { get; set; }

        public virtual Facility Facility { get; set; }
        public virtual ItemLocation ItemLocation { get; set; }
        public virtual Address ItemLocationAddress { get; set; }
        public virtual ItemInventoryTransaction Transaction { get; set; }
        public virtual ICollection<ProductionContainerItemArchive> ProductionContainerItemArchives { get; set; }
        public virtual ICollection<ProductionContainerItem> ProductionContainerItems { get; set; }
        public virtual ICollection<ProductionPackageItemArchive> ProductionPackageItemArchives { get; set; }
        public virtual ICollection<ProductionPackageItem> ProductionPackageItems { get; set; }
        public virtual ICollection<ProductionProposedMovementItemArchive> ProductionProposedMovementItemArchives { get; set; }
        public virtual ICollection<ProductionProposedMovementItem> ProductionProposedMovementItems { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionProposedMovement
    {
        public ProductionProposedMovement()
        {
            ProductionContainerItemArchives = new HashSet<ProductionContainerItemArchive>();
            ProductionContainerItems = new HashSet<ProductionContainerItem>();
            ProductionProposedMovementItemArchives = new HashSet<ProductionProposedMovementItemArchive>();
            ProductionProposedMovementItems = new HashSet<ProductionProposedMovementItem>();
        }

        public int ProductionProposedMovementId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemLocationTypeId { get; set; }
        public int ItemLocationId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? TrailerId { get; set; }
        public int? ShippingAgentId { get; set; }
        public int? Timbers { get; set; }
        /// <summary>
        /// Enter any additional notes you may wish to add about the contract.
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
        /// The Status of the Proposed Movement
        /// </summary>
        public int StatusId { get; set; }
        public int? FacilityId { get; set; }
        public int? FromFacilityId { get; set; }
        public int? AddressContactId { get; set; }
        public int? AddressId { get; set; }
        public int? ItemLocationAddressId { get; set; }
        public int? TransactionId { get; set; }
        public byte[] RowVersion { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ItemLocation ItemLocation { get; set; }
        public virtual ItemInventoryTransaction Transaction { get; set; }
        public virtual ICollection<ProductionContainerItemArchive> ProductionContainerItemArchives { get; set; }
        public virtual ICollection<ProductionContainerItem> ProductionContainerItems { get; set; }
        public virtual ICollection<ProductionProposedMovementItemArchive> ProductionProposedMovementItemArchives { get; set; }
        public virtual ICollection<ProductionProposedMovementItem> ProductionProposedMovementItems { get; set; }
    }
}

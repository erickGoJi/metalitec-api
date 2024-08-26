using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionContainer
    {
        public ProductionContainer()
        {
            ProductionContainerItemArchives = new HashSet<ProductionContainerItemArchive>();
            ProductionContainerItems = new HashSet<ProductionContainerItem>();
        }

        /// <summary>
        /// The system ID of the Container.
        /// </summary>
        public int ProductionContainerId { get; set; }
        /// <summary>
        /// The system name of the Container.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Description of the Container.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The Status of the Container.
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// The Faciltiy the Container is being dispatched from.
        /// </summary>
        public int? FacilityId { get; set; }
        /// <summary>
        /// The List Reference of the Container.
        /// </summary>
        public string List { get; set; }
        /// <summary>
        /// The Reference of the Container.
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
        /// The dispatch date of the Container.
        /// </summary>
        public DateTime? Date { get; set; }
        /// <summary>
        /// The label of the Container.
        /// </summary>
        public string Container { get; set; }
        /// <summary>
        /// The 1st seal code of the Container.
        /// </summary>
        public string Seal1 { get; set; }
        /// <summary>
        /// The second seal code of the Container.
        /// </summary>
        public string Seal2 { get; set; }
        /// <summary>
        /// The ship transporting the Container.
        /// </summary>
        public string Vessel { get; set; }
        /// <summary>
        /// The sailing date of the ship transporting the Container.
        /// </summary>
        public DateTime? SailDate { get; set; }
        /// <summary>
        /// The arrival date of the ship transporting the Container.
        /// </summary>
        public DateTime? Etadate { get; set; }
        /// <summary>
        /// Enter any additional notes you may wish to add about the Container.
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// The User who created the Container.
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Date the Container was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The last User to update the Container.
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// Date the Container was last updated.
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
    }
}

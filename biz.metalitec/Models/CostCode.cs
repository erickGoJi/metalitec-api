using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class CostCode
    {
        public CostCode()
        {
            AdditionTemplates = new HashSet<AdditionTemplate>();
            Additions = new HashSet<Addition>();
            ChangeOrderValuations = new HashSet<ChangeOrderValuation>();
            Employees = new HashSet<Employee>();
            EstimateExtras = new HashSet<EstimateExtra>();
            EstimateItemFittings = new HashSet<EstimateItemFitting>();
            Extras = new HashSet<Extra>();
            ItemListings = new HashSet<ItemListing>();
            Items = new HashSet<Item>();
            Processes = new HashSet<Process>();
            ProductionProcesses = new HashSet<ProductionProcess>();
            PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
            UserAuthorisationLimits = new HashSet<UserAuthorisationLimit>();
        }

        /// <summary>
        /// The unique cost code ID number generated automatically.
        /// </summary>
        public int CostCodeId { get; set; }
        /// <summary>
        /// Specify which cost centre the cost code belongs to.
        /// </summary>
        public int CostCentreId { get; set; }
        /// <summary>
        /// Specify a name for the cost code.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Give the cost code a description for future reference.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The budget availability option for this cost code.
        /// </summary>
        public int? BudgetGroupId { get; set; }
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
        public int System { get; set; }

        public virtual CostCentre CostCentre { get; set; }
        public virtual ICollection<AdditionTemplate> AdditionTemplates { get; set; }
        public virtual ICollection<Addition> Additions { get; set; }
        public virtual ICollection<ChangeOrderValuation> ChangeOrderValuations { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EstimateExtra> EstimateExtras { get; set; }
        public virtual ICollection<EstimateItemFitting> EstimateItemFittings { get; set; }
        public virtual ICollection<Extra> Extras { get; set; }
        public virtual ICollection<ItemListing> ItemListings { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Process> Processes { get; set; }
        public virtual ICollection<ProductionProcess> ProductionProcesses { get; set; }
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public virtual ICollection<UserAuthorisationLimit> UserAuthorisationLimits { get; set; }
    }
}

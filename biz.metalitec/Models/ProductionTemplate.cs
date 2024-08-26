using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionTemplate
    {
        public ProductionTemplate()
        {
            ProductionTemplateProcesses = new HashSet<ProductionTemplateProcess>();
            ProductionTemplateRuleVms = new HashSet<ProductionTemplateRuleVm>();
            ProductionTemplateRules = new HashSet<ProductionTemplateRule>();
        }

        public int ProductionTemplateId { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Contract, Contract Mark, Contract Item, Item, Service / Non Productive
        /// </summary>
        public int WorkOrderTypeId { get; set; }
        public int? WorkOrderCategoryId { get; set; }
        /// <summary>
        /// Standalone Mark,  Shop Assembly Child Mark, Shop Assembly
        /// </summary>
        public int AssemblyTypeId { get; set; }
        /// <summary>
        /// Shaft, Fitting, Other
        /// </summary>
        public int MarkItemTypeId { get; set; }
        /// <summary>
        /// Approved Status
        /// </summary>
        public byte Approved { get; set; }
        /// <summary>
        /// User when the approved checkbox was checked.
        /// </summary>
        public string ApprovedBy { get; set; }
        /// <summary>
        /// Date the approved checkbox was checked
        /// </summary>
        public DateTime? ApprovedOn { get; set; }
        public string Notes { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime UpdatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public bool LimitWorkstations { get; set; }
        public int FacilityId { get; set; }

        public virtual ICollection<ProductionTemplateProcess> ProductionTemplateProcesses { get; set; }
        public virtual ICollection<ProductionTemplateRuleVm> ProductionTemplateRuleVms { get; set; }
        public virtual ICollection<ProductionTemplateRule> ProductionTemplateRules { get; set; }
    }
}

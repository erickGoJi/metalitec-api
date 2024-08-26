using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    /// <summary>
    /// Hot Formed, Cold Formed, Cold Rolled, Misc
    /// </summary>
    public partial class SectionType
    {
        public SectionType()
        {
            AdditionWeights = new HashSet<AdditionWeight>();
            ItemLocationRuleItems = new HashSet<ItemLocationRuleItem>();
            ItemShortcutCodes = new HashSet<ItemShortcutCode>();
            Items = new HashSet<Item>();
            ProductionTemplateRuleItems = new HashSet<ProductionTemplateRuleItem>();
            ProductionWorkStationRuleItems = new HashSet<ProductionWorkStationRuleItem>();
        }

        public int SectionTypeId { get; set; }
        public int SectionRollTypeId { get; set; }
        public string Name { get; set; }
        public byte Enabled { get; set; }
        public byte Grades { get; set; }
        public byte Linear { get; set; }
        public int WeightCalcTypeId { get; set; }
        public int? CostCodeId { get; set; }
        public int? StruCadheadingId { get; set; }
        public string Code { get; set; }
        public byte IgnoreInNest { get; set; }
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
        public int PriceUnitId { get; set; }
        public byte? System { get; set; }
        public byte ProductionTypeId { get; set; }
        public bool IgnoreForAssembly { get; set; }
        public bool? CreateProductionWorkOrder { get; set; }
        public bool? BackFlush { get; set; }
        public bool CanRotateForNesting { get; set; }
        public int RegionId { get; set; }
        public string SectionNameMask { get; set; }
        public bool DisplayFlatInNestWizard { get; set; }
        public bool IsCustomGirder { get; set; }
        public bool FlipTeeForDstv { get; set; }
        public int ShapeId { get; set; }
        public byte? ScrapType { get; set; }

        public virtual Region Region { get; set; }
        public virtual SectionRollType SectionRollType { get; set; }
        public virtual ICollection<AdditionWeight> AdditionWeights { get; set; }
        public virtual ICollection<ItemLocationRuleItem> ItemLocationRuleItems { get; set; }
        public virtual ICollection<ItemShortcutCode> ItemShortcutCodes { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<ProductionTemplateRuleItem> ProductionTemplateRuleItems { get; set; }
        public virtual ICollection<ProductionWorkStationRuleItem> ProductionWorkStationRuleItems { get; set; }
    }
}

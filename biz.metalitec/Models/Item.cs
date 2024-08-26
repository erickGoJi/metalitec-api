using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Item
    {
        public Item()
        {
            ContractItems = new HashSet<ContractItem>();
            ContractPrelimMarks = new HashSet<ContractPrelimMark>();
            EstimateItemExtraRateValues = new HashSet<EstimateItemExtraRateValue>();
            Fittings = new HashSet<Fitting>();
            ItemCrossReferences = new HashSet<ItemCrossReference>();
            ItemCustomers = new HashSet<ItemCustomer>();
            ItemInventories = new HashSet<ItemInventory>();
            ItemInventoryArchives = new HashSet<ItemInventoryArchive>();
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            ItemLengths = new HashSet<ItemLength>();
            ItemLocationRuleItems = new HashSet<ItemLocationRuleItem>();
            ItemParameters = new HashSet<ItemParameter>();
            ItemSiteInventories = new HashSet<ItemSiteInventory>();
            ItemSuppliers = new HashSet<ItemSupplier>();
            ItemTrackings = new HashSet<ItemTracking>();
            NestResultsItemListings = new HashSet<NestResultsItemListing>();
            NestResultsStockListings = new HashSet<NestResultsStockListing>();
            ProductionTemplateRuleItems = new HashSet<ProductionTemplateRuleItem>();
            ProductionWorkStationRuleItems = new HashSet<ProductionWorkStationRuleItem>();
            PurchaseOrderItems = new HashSet<PurchaseOrderItem>();
            RollReferenceItems = new HashSet<RollReferenceItem>();
        }

        /// <summary>
        /// The unique item ID number generated automatically.
        /// </summary>
        public int ItemId { get; set; }
        public string ItemPartNumber { get; set; }
        /// <summary>
        /// Select whether this item is a steel or non steel item.
        /// </summary>
        public int ItemTypeId { get; set; }
        /// <summary>
        /// Specify an item group for the item.
        /// </summary>
        public int? ItemGroupId { get; set; }
        /// <summary>
        /// Specify an item class for the item.
        /// </summary>
        public int? ItemClassId { get; set; }
        /// <summary>
        /// Specify a date from when the item is available.
        /// </summary>
        public DateTime? EffectiveDate { get; set; }
        /// <summary>
        /// Specify a date at which the item expires.
        /// </summary>
        public DateTime? ExpiryDate { get; set; }
        public byte? Manufactured { get; set; }
        public string Name { get; set; }
        public string AltName { get; set; }
        /// <summary>
        /// Give the item a description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Specify the cost code under which the item will be priced.
        /// </summary>
        public int CostCodeId { get; set; }
        /// <summary>
        /// Weight per (EA, Area, Linear)
        /// </summary>
        public double Weight { get; set; }
        public int? RegionId { get; set; }
        /// <summary>
        /// Define the section type of the steel item.
        /// </summary>
        public int? SectionTypeId { get; set; }
        /// <summary>
        /// Enter the section size of the steel item.
        /// </summary>
        public string SectionSize { get; set; }
        /// <summary>
        /// Specify a steel grade for the steel item.
        /// </summary>
        public int? GradeId { get; set; }
        /// <summary>
        /// Specify the density of the steel item.
        /// </summary>
        public double Density { get; set; }
        /// <summary>
        /// Define the surface area of the steel item.
        /// </summary>
        public double SurfaceArea { get; set; }
        /// <summary>
        /// Specifies if the Item must be tracked in the inventory system
        /// </summary>
        public byte TrackingTypeId { get; set; }
        public byte? TrackInventoryLevel { get; set; }
        /// <summary>
        /// Enter any additional notes you wish to add concerning the item.
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
        public byte IgnoreInNest { get; set; }
        public byte ProductionTypeId { get; set; }
        public bool IgnoreForAssembly { get; set; }
        public double CrossSectionArea { get; set; }
        public double Perimeter { get; set; }
        /// <summary>
        /// For date descriptions use [year],[yy],[quarter],[qq],[month],[mm],[dayofyear],[dy], for Item descriptions use %item%,%section%,%sectionsize%,%grade%
        /// </summary>
        public string TrackNumberMask { get; set; }
        /// <summary>
        /// Specify the price that will be applied as default to all suppliers
        /// </summary>
        public double DefaultCostUnitPrice { get; set; }
        /// <summary>
        /// Specify the price unit that will be applied as default to all suppliers
        /// </summary>
        public int DefaultCostUnitId { get; set; }
        /// <summary>
        /// Specify the price that will be applied as default to all customers
        /// </summary>
        public double DefaultSellUnitPrice { get; set; }
        /// <summary>
        /// Specify the price unit that will be applied as default to all customers
        /// </summary>
        public int DefaultSellUnitId { get; set; }
        public bool? CreateProductionWorkOrder { get; set; }
        public bool? BackFlush { get; set; }
        /// <summary>
        /// The default price unit at which this Item is stored in Inventory.
        /// </summary>
        public int? DefaultInventoryUnitId { get; set; }
        public string Shape { get; set; }
        public int ScrapCostCodeId { get; set; }
        public bool CanReceiveInToInventory { get; set; }
        public bool DisplayFlatInNestWizard { get; set; }
        public double GirderBottomFlangeThickness { get; set; }
        public double GirderBottomFlangeWidth { get; set; }
        public double GirderDepth { get; set; }
        public int? GirderShapeId { get; set; }
        public double GirderTopFlangeThickness { get; set; }
        public double GirderTopFlangeWidth { get; set; }
        public double GirderTrueWebWidth { get; set; }
        public int? GirderTypeId { get; set; }
        public double GirderWebOffset { get; set; }
        public double GirderWebThickness { get; set; }
        public double? ScrapLimit { get; set; }

        public virtual CostCode CostCode { get; set; }
        public virtual Unit DefaultCostUnit { get; set; }
        public virtual Unit DefaultInventoryUnit { get; set; }
        public virtual Unit DefaultSellUnit { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual ItemType ItemType { get; set; }
        public virtual Region Region { get; set; }
        public virtual SectionType SectionType { get; set; }
        public virtual ICollection<ContractItem> ContractItems { get; set; }
        public virtual ICollection<ContractPrelimMark> ContractPrelimMarks { get; set; }
        public virtual ICollection<EstimateItemExtraRateValue> EstimateItemExtraRateValues { get; set; }
        public virtual ICollection<Fitting> Fittings { get; set; }
        public virtual ICollection<ItemCrossReference> ItemCrossReferences { get; set; }
        public virtual ICollection<ItemCustomer> ItemCustomers { get; set; }
        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<ItemInventoryArchive> ItemInventoryArchives { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<ItemLength> ItemLengths { get; set; }
        public virtual ICollection<ItemLocationRuleItem> ItemLocationRuleItems { get; set; }
        public virtual ICollection<ItemParameter> ItemParameters { get; set; }
        public virtual ICollection<ItemSiteInventory> ItemSiteInventories { get; set; }
        public virtual ICollection<ItemSupplier> ItemSuppliers { get; set; }
        public virtual ICollection<ItemTracking> ItemTrackings { get; set; }
        public virtual ICollection<NestResultsItemListing> NestResultsItemListings { get; set; }
        public virtual ICollection<NestResultsStockListing> NestResultsStockListings { get; set; }
        public virtual ICollection<ProductionTemplateRuleItem> ProductionTemplateRuleItems { get; set; }
        public virtual ICollection<ProductionWorkStationRuleItem> ProductionWorkStationRuleItems { get; set; }
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public virtual ICollection<RollReferenceItem> RollReferenceItems { get; set; }
    }
}

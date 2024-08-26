using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Facility
    {
        public Facility()
        {
            AdditionTemplates = new HashSet<AdditionTemplate>();
            AdditionTransports = new HashSet<AdditionTransport>();
            AdditionWeights = new HashSet<AdditionWeight>();
            ContractPriorities = new HashSet<ContractPriority>();
            Contracts = new HashSet<Contract>();
            Employees = new HashSet<Employee>();
            Enquiries = new HashSet<Enquiry>();
            EstimateAssemblies = new HashSet<EstimateAssembly>();
            Estimates = new HashSet<Estimate>();
            ExtraGroups = new HashSet<ExtraGroup>();
            Extras = new HashSet<Extra>();
            FacilityProcessWeeklyCapacities = new HashSet<FacilityProcessWeeklyCapacity>();
            FacilityTaskWeeklyCapacities = new HashSet<FacilityTaskWeeklyCapacity>();
            FittingGroups = new HashSet<FittingGroup>();
            Fittings = new HashSet<Fitting>();
            ItemInventories = new HashSet<ItemInventory>();
            ItemInventoryTransactionLines = new HashSet<ItemInventoryTransactionLine>();
            ItemLocations = new HashSet<ItemLocation>();
            ItemSiteInventories = new HashSet<ItemSiteInventory>();
            ItemUsages = new HashSet<ItemUsage>();
            ProductionContainers = new HashSet<ProductionContainer>();
            ProductionPackages = new HashSet<ProductionPackage>();
            PurchaseInvoices = new HashSet<PurchaseInvoice>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            SalesOrders = new HashSet<SalesOrder>();
            Suppliers = new HashSet<Supplier>();
            UserRoles = new HashSet<UserRole>();
            Users = new HashSet<User>();
        }

        public int FacilityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CurrencyId { get; set; }
        public int? DefaultCalendarId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public int System { get; set; }
        public double WeeklyCapacityWeight { get; set; }
        public double WeeklyCapacityMins { get; set; }
        public int? DefaultAssemblyLocationId { get; set; }
        public int? DefaultLocationId { get; set; }
        public int? DefaultOffcutLocationId { get; set; }
        public int? LandscapeTemplateId { get; set; }
        public int? PortraitTemplateId { get; set; }
        public int? AddressId { get; set; }
        public string CemarkingAccreditation { get; set; }
        public string AngleEngine { get; set; }
        public string LinearEngine { get; set; }
        public string PlateEngine { get; set; }
        public byte? PlateEngineUnits { get; set; }
        public bool? PlatePromptEditNest { get; set; }
        public bool? PlateShowApplication { get; set; }
        public string DivisionName { get; set; }
        public int? AngleEngineId { get; set; }
        public int? LinearEngineId { get; set; }
        public int? PlateEngineId { get; set; }
        public string DetailedPlanningNwdays { get; set; }
        public string Notes { get; set; }

        public virtual Currency Currency { get; set; }
        public virtual PlanningCalendar DefaultCalendar { get; set; }
        public virtual ItemLocation DefaultLocation { get; set; }
        public virtual ICollection<AdditionTemplate> AdditionTemplates { get; set; }
        public virtual ICollection<AdditionTransport> AdditionTransports { get; set; }
        public virtual ICollection<AdditionWeight> AdditionWeights { get; set; }
        public virtual ICollection<ContractPriority> ContractPriorities { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Enquiry> Enquiries { get; set; }
        public virtual ICollection<EstimateAssembly> EstimateAssemblies { get; set; }
        public virtual ICollection<Estimate> Estimates { get; set; }
        public virtual ICollection<ExtraGroup> ExtraGroups { get; set; }
        public virtual ICollection<Extra> Extras { get; set; }
        public virtual ICollection<FacilityProcessWeeklyCapacity> FacilityProcessWeeklyCapacities { get; set; }
        public virtual ICollection<FacilityTaskWeeklyCapacity> FacilityTaskWeeklyCapacities { get; set; }
        public virtual ICollection<FittingGroup> FittingGroups { get; set; }
        public virtual ICollection<Fitting> Fittings { get; set; }
        public virtual ICollection<ItemInventory> ItemInventories { get; set; }
        public virtual ICollection<ItemInventoryTransactionLine> ItemInventoryTransactionLines { get; set; }
        public virtual ICollection<ItemLocation> ItemLocations { get; set; }
        public virtual ICollection<ItemSiteInventory> ItemSiteInventories { get; set; }
        public virtual ICollection<ItemUsage> ItemUsages { get; set; }
        public virtual ICollection<ProductionContainer> ProductionContainers { get; set; }
        public virtual ICollection<ProductionPackage> ProductionPackages { get; set; }
        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<SalesOrder> SalesOrders { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

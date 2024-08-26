using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Contract
    {
        public Contract()
        {
            ApplicationForPayments = new HashSet<ApplicationForPayment>();
            ChangeOrderClientChangeOrders = new HashSet<ChangeOrderClientChangeOrder>();
            ChangeOrders = new HashSet<ChangeOrder>();
            ContractBatchContracts = new HashSet<ContractBatchContract>();
            ContractBatches = new HashSet<ContractBatch>();
            ContractBudgets = new HashSet<ContractBudget>();
            ContractBundles = new HashSet<ContractBundle>();
            ContractContacts = new HashSet<ContractContact>();
            ContractInvoiceSchedules = new HashSet<ContractInvoiceSchedule>();
            ContractListings = new HashSet<ContractListing>();
            ContractLotReleases = new HashSet<ContractLotRelease>();
            ContractPhases = new HashSet<ContractPhase>();
            ContractPriorities = new HashSet<ContractPriority>();
            Documents = new HashSet<Document>();
            EdifileContracts = new HashSet<EdifileContract>();
            Edifiles = new HashSet<Edifile>();
            ItemReservationContracts = new HashSet<ItemReservationContract>();
            ItemReservations = new HashSet<ItemReservation>();
            PurchaseInvoiceItemContracts = new HashSet<PurchaseInvoiceItemContract>();
            SalesInvoiceItems = new HashSet<SalesInvoiceItem>();
            SalesInvoices = new HashSet<SalesInvoice>();
            SalesOrderItems = new HashSet<SalesOrderItem>();
        }

        /// <summary>
        /// The unique contract ID number generated automatically.
        /// </summary>
        public int ContractId { get; set; }
        /// <summary>
        /// Specify a name for the contract.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Give the contract a description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Unique Project ID this Contract is associated with.
        /// </summary>
        public int? ProjectId { get; set; }
        public int StatusId { get; set; }
        public int? EnquiryId { get; set; }
        /// <summary>
        /// Unique Customer ID for customer associated with this contract.
        /// </summary>
        public int CustomerId { get; set; }
        public int? LocationId { get; set; }
        public int? AddressId { get; set; }
        public int? ContractCategoryId { get; set; }
        /// <summary>
        /// Unique ID for Default grade
        /// </summary>
        public int? DefaultGradeId { get; set; }
        public string DefaultPaintFinish { get; set; }
        /// <summary>
        /// Total Weight for this Contract
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Total Area for this Contract
        /// </summary>
        public double Area { get; set; }
        public DateTime? ProductionStartDate { get; set; }
        public DateTime? ProductionDispatchDate { get; set; }
        public DateTime? SiteDeliveryDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string CadPath { get; set; }
        public string CamPath { get; set; }
        public string StruWalkerPath { get; set; }
        /// <summary>
        /// ~Adds the value of offcut pieces to the contract and return the item as 0 value 
        /// </summary>
        public bool AddOffcutValue { get; set; }
        /// <summary>
        /// ~Adds the value of scrap to the contract and removes the scap at a value of 0
        /// </summary>
        public bool AddScrapValue { get; set; }
        /// <summary>
        /// Specify whether the offcuts will by default be allocated to free inventory or to the contract
        /// </summary>
        public bool? OffcutAllocationToContract { get; set; }
        public string StruCadphaseAttributeName { get; set; }
        public string StruCadlotAttributeName { get; set; }
        public string StruCaddescriptionAttributeName { get; set; }
        public string StruCadpaintFinishAttributeName { get; set; }
        public string StruCadprelimAttributeName { get; set; }
        /// <summary>
        /// ~1 = Manual, 2 = Cad
        /// </summary>
        public byte PhaseSource { get; set; }
        /// <summary>
        /// ~1 = Manual, 2 = Cad
        /// </summary>
        public byte LotSource { get; set; }
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
        public bool? IndividualMarkTracking { get; set; }
        public bool? IndividualMarkItemTracking { get; set; }
        public string CustomerReference { get; set; }
        public int ContractTypeId { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        public int CurrencyId { get; set; }
        /// <summary>
        /// Date of Exchange Rate
        /// </summary>
        public DateTime? ExchangeRateDate { get; set; }
        /// <summary>
        /// Exchange Rate
        /// </summary>
        public double ExchangeRate { get; set; }
        public double ContractValue { get; set; }
        public double? ContractOriginalValue { get; set; }
        public double? ContractInvoicedValue { get; set; }
        public double? ContractOriginalInvoicedValue { get; set; }
        public bool CadUseDocumentManagement { get; set; }
        public bool CamUseDocumentManagement { get; set; }
        public bool StruWalkerUseDocumentManagement { get; set; }
        /// <summary>
        /// The priority of the Contract
        /// </summary>
        public int? Priority { get; set; }
        /// <summary>
        /// The default QS Analysis of the Contract
        /// </summary>
        public int? DefaultQsanalysisId { get; set; }
        public int? ContactId { get; set; }
        public bool ContractProgressRestrictionDeliveryNote { get; set; }
        public bool ContractProgressRestrictionDetailListing { get; set; }
        public bool ContractProgressRestrictionLotting { get; set; }
        public bool ContractProgressRestrictionNesting { get; set; }
        public bool ContractProgressRestrictionPrelimListing { get; set; }
        public bool ContractProgressRestrictionPurchaseOrder { get; set; }
        public bool ContractProgressRestrictionWorkOrder { get; set; }
        public int FacilityId { get; set; }
        public int? CustomerContractTypeId { get; set; }
        /// <summary>
        /// Specfiy if the detailed listing mark / mark item unique instance GUID is imported from the CAD source
        /// </summary>
        public byte Guidsource { get; set; }
        public string BimreviewAssemblyMarkAttributeName { get; set; }
        public string BimreviewGuidattributeName { get; set; }
        public string BimreviewMarkAttributeName { get; set; }
        public string BimreviewMarkItemAttributeName { get; set; }
        public int ExecutionClassId { get; set; }
        /// <summary>
        /// Specify the path for the NC files to be stored once they have been created from the CAM Splitter
        /// </summary>
        public string CamSplitterPath { get; set; }
        public int? OffSiteItemLocationId { get; set; }
        public double DefaultHoursPerWeight { get; set; }
        public int? EstimatorId { get; set; }
        public double? OriginalContractValue { get; set; }
        public int? SalesmanId { get; set; }
        public double DefaultRetention { get; set; }
        public DateTime? InvoiceCompletionDate { get; set; }
        public DateTime? RetentionDueDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Qsanalysis DefaultQsanalysis { get; set; }
        public virtual Facility Facility { get; set; }
        public virtual ItemLocation Location { get; set; }
        public virtual ItemLocation OffSiteItemLocation { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<ApplicationForPayment> ApplicationForPayments { get; set; }
        public virtual ICollection<ChangeOrderClientChangeOrder> ChangeOrderClientChangeOrders { get; set; }
        public virtual ICollection<ChangeOrder> ChangeOrders { get; set; }
        public virtual ICollection<ContractBatchContract> ContractBatchContracts { get; set; }
        public virtual ICollection<ContractBatch> ContractBatches { get; set; }
        public virtual ICollection<ContractBudget> ContractBudgets { get; set; }
        public virtual ICollection<ContractBundle> ContractBundles { get; set; }
        public virtual ICollection<ContractContact> ContractContacts { get; set; }
        public virtual ICollection<ContractInvoiceSchedule> ContractInvoiceSchedules { get; set; }
        public virtual ICollection<ContractListing> ContractListings { get; set; }
        public virtual ICollection<ContractLotRelease> ContractLotReleases { get; set; }
        public virtual ICollection<ContractPhase> ContractPhases { get; set; }
        public virtual ICollection<ContractPriority> ContractPriorities { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<EdifileContract> EdifileContracts { get; set; }
        public virtual ICollection<Edifile> Edifiles { get; set; }
        public virtual ICollection<ItemReservationContract> ItemReservationContracts { get; set; }
        public virtual ICollection<ItemReservation> ItemReservations { get; set; }
        public virtual ICollection<PurchaseInvoiceItemContract> PurchaseInvoiceItemContracts { get; set; }
        public virtual ICollection<SalesInvoiceItem> SalesInvoiceItems { get; set; }
        public virtual ICollection<SalesInvoice> SalesInvoices { get; set; }
        public virtual ICollection<SalesOrderItem> SalesOrderItems { get; set; }
    }
}

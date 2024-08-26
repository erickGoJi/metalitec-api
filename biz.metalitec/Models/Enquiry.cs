using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Enquiry
    {
        public Enquiry()
        {
            EnquiryProjectPeople = new HashSet<EnquiryProjectPerson>();
            EstimateEnquiries = new HashSet<EstimateEnquiry>();
        }

        /// <summary>
        /// Unique enquiry ID number
        /// </summary>
        public int EnquiryId { get; set; }
        /// <summary>
        /// Specify the enquiry name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ~The customer table foreign key
        /// </summary>
        public int CustomerId { get; set; }
        public string AddressId { get; set; }
        /// <summary>
        /// ~The client category table foreign key
        /// </summary>
        public int? EnquiryCategoryId { get; set; }
        /// <summary>
        /// ~The enquiry table foreign key (cyclic link)
        /// </summary>
        public int? AsQuoteId { get; set; }
        /// <summary>
        /// ~The estimate table foreign key
        /// </summary>
        public int? EstimateId { get; set; }
        /// <summary>
        /// Give the project a description.
        /// </summary>
        public string Project { get; set; }
        /// <summary>
        /// Specify the location of the project.
        /// </summary>
        public string Location { get; set; }
        /// <summary>
        /// Select from list, or enter sales area of project.
        /// </summary>
        public int? SalesAreaId { get; set; }
        /// <summary>
        /// ~The building type table foreign key
        /// </summary>
        public int? BuildingTypeId { get; set; }
        /// <summary>
        /// The estimated size of the enquiry
        /// </summary>
        public double? EnquirySize { get; set; }
        /// <summary>
        /// The estimated weight of the enquiry
        /// </summary>
        public double? EnquiryWeight { get; set; }
        /// <summary>
        /// ~The design type  table foreign key
        /// </summary>
        public int? DesignTypeId { get; set; }
        /// <summary>
        /// ~The designer table foreign key
        /// </summary>
        public int? DesignerId { get; set; }
        /// <summary>
        /// ~The architect table foreign key
        /// </summary>
        public int? ArchitectId { get; set; }
        /// <summary>
        /// ~The engineer table foreign key
        /// </summary>
        public int? EngineerId { get; set; }
        /// <summary>
        /// Select from a list, or enter the proposed quantity surveyor.
        /// </summary>
        public int? QuantitySurveyorId { get; set; }
        /// <summary>
        /// The start date of the design
        /// </summary>
        public DateTime? DesignStartDate { get; set; }
        /// <summary>
        /// The finish of the design
        /// </summary>
        public DateTime? DesignFinishDate { get; set; }
        /// <summary>
        /// Select from list the current status of the tender.
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// The final bid date of the enquiry
        /// </summary>
        public DateTime? BidDate { get; set; }
        /// <summary>
        /// The date of the enquiry if won
        /// </summary>
        public DateTime? DateWon { get; set; }
        /// <summary>
        /// ~The contract table foreign key
        /// </summary>
        public int? ContractId { get; set; }
        /// <summary>
        /// The final estimate weight for the enquiry.
        /// </summary>
        public double? FinalWeight { get; set; }
        /// <summary>
        /// The final estimate area for the enquiry
        /// </summary>
        public double? FinalArea { get; set; }
        /// <summary>
        /// The final estimate value for the enquiry
        /// </summary>
        public double? FinalValue { get; set; }
        /// <summary>
        /// Define a return percentage from the project.
        /// </summary>
        public double? PercentReturn { get; set; }
        /// <summary>
        /// The date the enquiry was received
        /// </summary>
        public DateTime? EnquiryReceived { get; set; }
        /// <summary>
        /// Enter the date the tender was returned.
        /// </summary>
        public DateTime? TenderReturnDate { get; set; }
        /// <summary>
        /// The date the enquiry was declined
        /// </summary>
        public DateTime? DeclinedDate { get; set; }
        /// <summary>
        /// Specify the order start date.
        /// </summary>
        public DateTime? OrderStartDate { get; set; }
        /// <summary>
        /// Enter the date construction is set to commence.
        /// </summary>
        public DateTime? SteelStartDate { get; set; }
        /// <summary>
        /// Enter any additional notes you may wish to add about the enquiry.
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public byte? System { get; set; }
        public int EnquiryStatusId { get; set; }
        public string TermsAndConditions { get; set; }
        public bool IncludeTermsAndConditions { get; set; }
        public string ScopeOfWork { get; set; }
        public bool IncludeScopeOfWork { get; set; }
        public string Includes { get; set; }
        public bool IncludeIncludes { get; set; }
        public string Excludes { get; set; }
        public bool IncludeExcludes { get; set; }
        public bool UseFinalWeight { get; set; }
        public double AdjustedWeight { get; set; }
        public bool UseFinalValue { get; set; }
        public double AdjustedValue { get; set; }
        /// <summary>
        /// The Customer Contact
        /// </summary>
        public int? ContactId { get; set; }
        public bool IncludeBreakdown { get; set; }
        public int CurrencyId { get; set; }
        public int FacilityId { get; set; }
        public int? EnquiryAdminBidBond { get; set; }
        public int? EnquiryAdminCertifiedPayroll { get; set; }
        public int? EnquiryAdminLdpenalty { get; set; }
        public int? EnquiryAdminOcipccip { get; set; }
        public int? EnquiryAdminOtherTaxes { get; set; }
        public int? EnquiryAdminPaymentTerms { get; set; }
        public int? EnquiryAdminPerfBond { get; set; }
        public int? EnquiryAdminRetentionTerms { get; set; }
        public int? EnquiryAdminSalesTax { get; set; }
        public int? EnquiryAdminWarrantyPeriod { get; set; }
        public int? EnquiryFabErectCert { get; set; }
        public int? EnquiryFabLocalParticipation { get; set; }
        public int? EnquiryFabMarketRetention { get; set; }
        public int? EnquiryFabNdtinsp { get; set; }
        public int? EnquiryFabPaintCert { get; set; }
        public int? EnquiryFabSbeparticipation { get; set; }
        public int? EnquiryFabShopCert { get; set; }
        public int? EnquiryMaterialBuyAmerica { get; set; }
        public int? EnquiryMaterialBuyAmerican { get; set; }
        public int? EnquiryMaterialDomestic { get; set; }
        public int? EnquiryMaterialLeed { get; set; }
        public int? EnquiryMaterialUniqueMaterial { get; set; }
        public string EnquiryNdaagreement { get; set; }
        public string EnquiryPreQualification { get; set; }
        public int? EnquiryScopeBim { get; set; }
        public int? EnquiryScopeDesign { get; set; }
        public int? EnquiryScopeDetail { get; set; }
        public int? EnquiryScopeErection { get; set; }
        public int? EnquiryScopeFab { get; set; }
        public int? EnquiryScopeFreight { get; set; }
        public int? EnquiryScopeOther1 { get; set; }
        public int? EnquiryScopeOther2 { get; set; }
        public int? EnquiryScopeOther3 { get; set; }
        public int? EnquiryScopeOther4 { get; set; }
        public int? EnquiryScopePaint { get; set; }
        public int? EnquiryScopePrep { get; set; }
        public int? EstimatorId { get; set; }
        public int? ProjectManagerId { get; set; }
        public int? SalesmanId { get; set; }
        public double? ExchangeRate { get; set; }
        public DateTime? ExchangeRateDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Facility Facility { get; set; }
        public virtual ICollection<EnquiryProjectPerson> EnquiryProjectPeople { get; set; }
        public virtual ICollection<EstimateEnquiry> EstimateEnquiries { get; set; }
    }
}

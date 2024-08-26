using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportEnquiry
    {
        public int EnquiryId { get; set; }
        public string Enquiry { get; set; }
        public string EnquiryStatus { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public string EnquiryContact { get; set; }
        public string EnquiryTelephone { get; set; }
        public string EnquiryFaxNumber { get; set; }
        public string EnquiryMobilePhoneNumber { get; set; }
        public string EnquiryEMailAddress { get; set; }
        public int? AddressId { get; set; }
        public string EnquiryAddressLine1 { get; set; }
        public string EnquiryAddressLine2 { get; set; }
        public string EnquiryAddressLine3 { get; set; }
        public string EnquiryAddressLine4 { get; set; }
        public string EnquiryPostCode { get; set; }
        public string EnquiryCountry { get; set; }
        public string EnquiryCategory { get; set; }
        public string AsEnquiry { get; set; }
        public int? EstimateId { get; set; }
        public string Estimate { get; set; }
        public string Project { get; set; }
        public string Location { get; set; }
        public string SalesArea { get; set; }
        public string BuildingType { get; set; }
        public double? EnquirySize { get; set; }
        public double? EnquiryWeight { get; set; }
        public string DesignType { get; set; }
        public string Designer { get; set; }
        public string Architect { get; set; }
        public string Engineer { get; set; }
        public string QuantitySurveyor { get; set; }
        public DateTime? DesignStartDate { get; set; }
        public DateTime? DesignFinishDate { get; set; }
        public string BidStatus { get; set; }
        public DateTime? BidDate { get; set; }
        public DateTime? DateWon { get; set; }
        public int? ContractId { get; set; }
        public string Contract { get; set; }
        public double? FinalWeight { get; set; }
        public double? FinalArea { get; set; }
        public double? FinalValue { get; set; }
        public double? PercentReturn { get; set; }
        public DateTime? EnquiryReceived { get; set; }
        public DateTime? TenderReturnDate { get; set; }
        public DateTime? DeclinedDate { get; set; }
        public DateTime? OrderStartDate { get; set; }
        public DateTime? SteelStartDate { get; set; }
        public string TermsAndConditions { get; set; }
        public bool IncludesTermsAndConditions { get; set; }
        public string ScopeOfWork { get; set; }
        public bool IncludesScopeOfWork { get; set; }
        public string Includes { get; set; }
        public bool IncludesIncludes { get; set; }
        public string Excludes { get; set; }
        public bool IncludesExcludes { get; set; }
        public bool UseFinalWeight { get; set; }
        public double AdjustedWeight { get; set; }
        public bool UseFinalValue { get; set; }
        public double AdjustedValue { get; set; }
        public string EnquiryNotes { get; set; }
    }
}

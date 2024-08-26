using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportContract
    {
        public int ContractId { get; set; }
        public string Contract { get; set; }
        public string ContractDescription { get; set; }
        public string Project { get; set; }
        public string ProjectDescription { get; set; }
        public string ContractStatus { get; set; }
        public int? EnquiryId { get; set; }
        public string Enquiry { get; set; }
        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public string CustomerReference { get; set; }
        public string ContractContact { get; set; }
        public string ContractTelephone { get; set; }
        public string ContractFaxNumber { get; set; }
        public string ContractMobilePhoneNumber { get; set; }
        public string ContractEMailAddress { get; set; }
        public string SiteAddressLine1 { get; set; }
        public string SiteAddressLine2 { get; set; }
        public string SiteAddressLine3 { get; set; }
        public string SiteAddressLine4 { get; set; }
        public string SiteAddressPostCode { get; set; }
        public string SiteAddressCountry { get; set; }
        public string SiteContact { get; set; }
        public string SiteTelephone { get; set; }
        public string SiteFaxNumber { get; set; }
        public string SiteMobilePhoneNumber { get; set; }
        public string SiteEMailAddress { get; set; }
        public byte? ShowInOrdering { get; set; }
        public string ContractAddressLine1 { get; set; }
        public string ContractAddressLine2 { get; set; }
        public string ContractAddressLine3 { get; set; }
        public string ContractAddressLine4 { get; set; }
        public string ContractAddressPostCode { get; set; }
        public string ContractAddressCountry { get; set; }
        public string DefaultGrade { get; set; }
        public string PaintFinish { get; set; }
        public double TotalContractWeight { get; set; }
        public double TotalContractArea { get; set; }
        public string Currency { get; set; }
        public DateTime? ExchangeRateDate { get; set; }
        public double ExchangeRate { get; set; }
        public DateTime? ProductionStartDate { get; set; }
        public DateTime? ProductionDispatchDate { get; set; }
        public DateTime? SiteDeliveryDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string CadDataPath { get; set; }
        public bool CadUseDocumentManagement { get; set; }
        public string CamDataPath { get; set; }
        public bool CamUseDocumentManagement { get; set; }
        public string StruWalkerFile { get; set; }
        public bool StruWalkerUseDocumentManagement { get; set; }
        public bool AddFreeOffcutValueToContract { get; set; }
        public bool AddScrapValueToContract { get; set; }
        public bool AllocateOffcutToContract { get; set; }
        public string StruCadAttributeMappingPhaseZone { get; set; }
        public string StruCadAttributeMappingLotLoad { get; set; }
        public string StruCadAttributeMappingDescription { get; set; }
        public string StruCadAttributeMappingPaintFinish { get; set; }
        public string StruCadAttributeMappingPrelimMark { get; set; }
        public byte PhaseZoneSource { get; set; }
        public byte LotLoadSource { get; set; }
        public bool ProductionTrackingIndividualMarkTracking { get; set; }
        public bool ProductionTrackingIndividualMarkItemTracking { get; set; }
        public string ContractNotes { get; set; }
        public string ContractType { get; set; }
    }
}

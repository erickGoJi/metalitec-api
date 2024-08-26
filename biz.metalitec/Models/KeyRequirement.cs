using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class KeyRequirement
    {
        public int KeyRequirementsId { get; set; }
        public byte? Krtype { get; set; }
        public int? KrlinkId { get; set; }
        public int? ScopeDesignId { get; set; }
        public int? ScopeFabId { get; set; }
        public int? ScopePrepId { get; set; }
        public int? ScopeErectionId { get; set; }
        public int? ScopeBimid { get; set; }
        public int? ScopeDetailId { get; set; }
        public int? ScopePaintId { get; set; }
        public int? ScopeFreightId { get; set; }
        public int? ScopeCustom1 { get; set; }
        public int? ScopeCustom2 { get; set; }
        public int? ScopeCustom3 { get; set; }
        public int? ScopeCustom4 { get; set; }
        public int? ScopeCustom5 { get; set; }
        public int? ScopeCustom6 { get; set; }
        public int? ScopeCustom7 { get; set; }
        public int? ScopeCustom8 { get; set; }
        public int? MaterialLeedId { get; set; }
        public int? MaterialBuyAmericanId { get; set; }
        public int? MaterialUniqueMaterialId { get; set; }
        public int? MaterialDomesticId { get; set; }
        public int? FabPaintCertId { get; set; }
        public int? FabErectCertId { get; set; }
        public int? FabLocalParticipationId { get; set; }
        public int? FabShopCertId { get; set; }
        public int? FabNdtinspId { get; set; }
        public int? FabSbeparticipationId { get; set; }
        public int? FabMarketRetentionId { get; set; }
        public int? AdminSalesTaxId { get; set; }
        public int? AdminWarrantyPeriodId { get; set; }
        public int? AdminLdpenaltyId { get; set; }
        public int? AdminBidBondId { get; set; }
        public int? AdminPerfBondId { get; set; }
        public int? AdminOtherTaxesId { get; set; }
        public int? AdminPaymentTermsId { get; set; }
        public int? AdminRetentionTermsId { get; set; }
        public int? AdminCertifiedPayrollId { get; set; }
        public int? AdminOcipccipid { get; set; }
        public double? ShopRateRegular { get; set; }
        public double? ShopRateOvertime { get; set; }
        public double? ShopRateDouble { get; set; }
        public double? FieldRateRegular { get; set; }
        public double? FieldRateOvertime { get; set; }
        public double? FieldRateDouble { get; set; }
        public double? DetailRateRegular { get; set; }
        public double? DetailRateOvertime { get; set; }
        public double? DetailRateDouble { get; set; }
        public double? Crane { get; set; }
        public double? Freight { get; set; }
        public double? Scrap { get; set; }
        public double? Sga { get; set; }
        public double? Profit { get; set; }
        public string NdaagreementPath { get; set; }
        public string PreQualificationPath { get; set; }
    }
}

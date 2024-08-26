using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportQsanalysislisting
    {
        public int QsanalysisListingId { get; set; }
        public int QsanalysisId { get; set; }
        public string QsCategory { get; set; }
        public string QsCategoryDescription { get; set; }
        public int QsCategoryUnit { get; set; }
        public double TotalWeight { get; set; }
        public double TotalArea { get; set; }
        public double TotalCostValue { get; set; }
        public double TotalCostUnitValue { get; set; }
        public double TotalSellValue { get; set; }
        public double TotalSellUnitValue { get; set; }
        public string QsCategoryNotes { get; set; }
        public int SortOrder { get; set; }
        public string QsCategoryType { get; set; }
        public string Mark { get; set; }
        public string MarkItem { get; set; }
        public string Item { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public double Quantity { get; set; }
        public double CostValue { get; set; }
        public double SellValue { get; set; }
        public bool ManuallyCategorised { get; set; }
        public double MarkItemQuantity { get; set; }
        public double MarkItemLength { get; set; }
        public double MarkItemWidth { get; set; }
        public string MarkItemPreliminaryMark { get; set; }
        public string MarkItemPaintFinish { get; set; }
        public string MarkItemCutType { get; set; }
        public bool RevisedItem { get; set; }
        public bool RemovedItem { get; set; }
        public string Rule { get; set; }
        public double? RuleMinValue { get; set; }
        public double? RuleMaxValue { get; set; }
        public string RuleValue { get; set; }
        public bool RuleNotAllowed { get; set; }
        public int? ItemId { get; set; }
        public string RuleItems { get; set; }
        public string RuleSectionTypes { get; set; }
    }
}

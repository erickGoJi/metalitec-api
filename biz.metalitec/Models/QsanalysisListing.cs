using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class QsanalysisListing
    {
        public int QsanalysisListingId { get; set; }
        public int QsanalysisCategoryId { get; set; }
        /// <summary>
        /// ~~(1=Detail Listing, 2=Estimate Item, 3 = Estimate Fitting)
        /// </summary>
        public byte ListingTypeId { get; set; }
        /// <summary>
        /// The EstimateItemFittingID, ItemListingID or MarkItemID
        /// </summary>
        public int ListingId { get; set; }
        /// <summary>
        /// The Weight of the listed Item
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// The Area of the Listed Item
        /// </summary>
        public double Area { get; set; }
        /// <summary>
        /// The Quantity of Listed Items
        /// </summary>
        public double Quantity { get; set; }
        public double CostValue { get; set; }
        public double SellValue { get; set; }
        /// <summary>
        /// Signifies that the User Manually Categorised the Listing Item
        /// </summary>
        public bool ManuallyCategorised { get; set; }
        public string Mark { get; set; }
        public string ListedItem { get; set; }
        public string Item { get; set; }
        public double MarkItemQuantity { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public string MarkItemPrelimMark { get; set; }
        public string PaintFinish { get; set; }
        public string MarkItemCutType { get; set; }
        public bool RevisedItem { get; set; }
        public bool RemovedItem { get; set; }
        public double MarkItemStartTopFlangeAngle { get; set; }
        public double MarkItemEndTopFlangeAngle { get; set; }
        public double MarkItemStartWebAngle { get; set; }
        public double MarkItemEndWebAngle { get; set; }
        public double MarkItemStartBottomFlangeAngle { get; set; }
        public double MarkItemEndBottomFlangeAngle { get; set; }

        public virtual QsanalysisCategory QsanalysisCategory { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestResultsItemListing
    {
        public int NestItemListingId { get; set; }
        /// <summary>
        /// ~1 = Estimating, 2 = Prelim 3 = Detailed Listing
        /// </summary>
        public int NestSourceTypeId { get; set; }
        /// <summary>
        /// For example the EstimateID
        /// </summary>
        public int SourceKey { get; set; }
        /// <summary>
        /// The ItemID of the Item
        /// </summary>
        public int ItemId { get; set; }
        public int ItemListingId { get; set; }
        /// <summary>
        /// Length in MM
        /// </summary>
        public double Length { get; set; }
        /// <summary>
        /// The stock length
        /// </summary>
        public int StockId { get; set; }
        public int Last { get; set; }
        /// <summary>
        /// The prelim mark ID if the cut is for a prelim mark
        /// </summary>
        public int? ContractPrelimMarkId { get; set; }
        /// <summary>
        /// ~The mark id where the cut is used - could be markitemid
        /// </summary>
        public int? MarkId { get; set; }
        /// <summary>
        /// The phase id where the cut is used
        /// </summary>
        public int? PhaseId { get; set; }
        public int? SourceSubKey { get; set; }
        public double Width { get; set; }

        public virtual Item Item { get; set; }
    }
}

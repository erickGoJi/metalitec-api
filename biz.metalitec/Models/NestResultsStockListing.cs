using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestResultsStockListing
    {
        public int NestStockListingId { get; set; }
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
        /// <summary>
        /// The stock length from which the item is cut from
        /// </summary>
        public int StockId { get; set; }
        public double Length { get; set; }
        public double Cost { get; set; }
        /// <summary>
        /// number of items being cut from the bar
        /// </summary>
        public int Items { get; set; }
        public int LayoutNo { get; set; }
        public double Waste { get; set; }
        public int? ItemReservationId { get; set; }
        public int? SourceSubKey { get; set; }
        public int? PriceUnitId { get; set; }
        public double? WasteArea { get; set; }
        public double Width { get; set; }
        public int Quantity { get; set; }

        public virtual Item Item { get; set; }
        public virtual ItemReservation ItemReservation { get; set; }
    }
}

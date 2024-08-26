using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EstimateItemFitting
    {
        public EstimateItemFitting()
        {
            EstimateItemFittingProcesses = new HashSet<EstimateItemFittingProcess>();
        }

        public int EstimateItemFittingId { get; set; }
        public int ItemListingId { get; set; }
        public int? FittingId { get; set; }
        public int? ItemId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public double Value { get; set; }
        public double UnitPrice { get; set; }
        public int UnitId { get; set; }
        public int PriceSourceId { get; set; }
        public int CostCodeId { get; set; }
        public int? TempKey { get; set; }
        public int Version { get; set; }
        public byte? ReviewedRateId { get; set; }
        /// <summary>
        /// ~The type of fitting specifying its source, 0=Library Fitting, 1=Steel Item, 2=Non-Steel Item
        /// </summary>
        public int FittingTypeId { get; set; }
        public bool IsLabourUsageFitting { get; set; }
        public string Notes { get; set; }
        public string Reference { get; set; }

        public virtual CostCode CostCode { get; set; }
        public virtual Fitting Fitting { get; set; }
        public virtual ItemListing ItemListing { get; set; }
        public virtual ICollection<EstimateItemFittingProcess> EstimateItemFittingProcesses { get; set; }
    }
}

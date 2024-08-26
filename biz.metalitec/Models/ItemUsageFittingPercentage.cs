using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ItemUsageFittingPercentage
    {
        public int ItemUsageFittingPercentageId { get; set; }
        public int ItemUsageId { get; set; }
        public double ToLength { get; set; }
        /// <summary>
        /// The estimate fittings per weight percentage
        /// </summary>
        public double? FittingsPerWeight { get; set; }
        /// <summary>
        /// The estimate rate over weight value
        /// </summary>
        public double? RatePerWeightValue { get; set; }
        /// <summary>
        /// The estimate hours over weight value
        /// </summary>
        public double? HoursPerWeightValue { get; set; }

        public virtual ItemUsage ItemUsage { get; set; }
    }
}

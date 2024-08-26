using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EstimateSubsectionSetItem
    {
        public int EstimateSubsectionSetItemId { get; set; }
        /// <summary>
        /// Unique Subsection Set ID number.
        /// </summary>
        public int EstimateSubsectionSetId { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public int? BoqunitId { get; set; }

        public virtual EstimateSubsectionSet EstimateSubsectionSet { get; set; }
    }
}

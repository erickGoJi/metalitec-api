using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class FittingGroupItem
    {
        public int FittingGroupItemId { get; set; }
        public int FittingGroupId { get; set; }
        /// <summary>
        /// ~1 - Fitting ; 2 - Fitting Group
        /// </summary>
        public int FittingItemTypeId { get; set; }
        public int LineItemId { get; set; }
        public int Quantity { get; set; }

        public virtual FittingGroup FittingGroup { get; set; }
    }
}

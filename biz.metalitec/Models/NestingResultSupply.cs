using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestingResultSupply
    {
        public NestingResultSupply()
        {
            NestingResultSupplyLengths = new HashSet<NestingResultSupplyLength>();
        }

        public int NestingResultSupplyId { get; set; }
        public int NestResultId { get; set; }
        public bool? Include { get; set; }
        /// <summary>
        /// Where the material comes from: 1 - Inventory, 2 - Supplier
        /// </summary>
        public byte SourceType { get; set; }
        /// <summary>
        /// The ItemID of the item that is used in nesting (Link to NestingRequiredItem)
        /// </summary>
        public int UsedItemId { get; set; }
        public int? SupplierId { get; set; }
        public double? UnitPrice { get; set; }
        public int? UnitId { get; set; }
        public int? CurrencyId { get; set; }
        /// <summary>
        /// IF ordered from the supplier, append to a po or if null, create a new po
        /// </summary>
        public int? PurchaseOrderId { get; set; }
        /// <summary>
        /// For SupplyType inventory - display the lower grades
        /// </summary>
        public bool UseLowerGrades { get; set; }
        /// <summary>
        /// For SupplyType inventory - display the higher grades
        /// </summary>
        public bool UseHigherGrades { get; set; }
        public bool UseSameRatedGrades { get; set; }

        public virtual NestingResult NestResult { get; set; }
        public virtual ICollection<NestingResultSupplyLength> NestingResultSupplyLengths { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestingResultSupplyArchive
    {
        public int NestingResultSupplyId { get; set; }
        public int NestResultId { get; set; }
        public bool Include { get; set; }
        public byte SourceType { get; set; }
        public int UsedItemId { get; set; }
        public int? SupplierId { get; set; }
        public double? UnitPrice { get; set; }
        public int? UnitId { get; set; }
        public int? CurrencyId { get; set; }
        public int? PurchaseOrderId { get; set; }
        public bool? UseLowerGrades { get; set; }
        public bool? UseHigherGrades { get; set; }
        public bool? UseSameRatedGrades { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwRptIteminventoryInout
    {
        public int TransactionId { get; set; }
        public string TransactionName { get; set; }
        public string Description { get; set; }
        public int ItemTransactionTypeId { get; set; }
        public DateTime Date { get; set; }
        public int TransActionLineId { get; set; }
        public int Direction { get; set; }
        public int? LineTypeId { get; set; }
        public int? ItemId { get; set; }
        public string Item { get; set; }
        public int? SectionTypeId { get; set; }
        public int? MarkId { get; set; }
        public int FacilityId { get; set; }
        public string Facility { get; set; }
        public int? ItemLocationId { get; set; }
        public string Location { get; set; }
        public string YardReference { get; set; }
        public string Classification { get; set; }
        public int? SupplierId { get; set; }
        public string CastReference { get; set; }
        public string PurchaseOrder { get; set; }
        public string Receipt { get; set; }
        public double Quantity { get; set; }
        public double? UndoneQuantity { get; set; }
        public double? Length { get; set; }
        public double? Width { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public double UnitPrice { get; set; }
        public string Unit { get; set; }
        public double Value { get; set; }
        public string Project { get; set; }
        public string Contract { get; set; }
        public string Phase { get; set; }
        public string Supplier { get; set; }
        public string ProductionWorkOrder { get; set; }
        public int LineItemTransactionTypeId { get; set; }
    }
}

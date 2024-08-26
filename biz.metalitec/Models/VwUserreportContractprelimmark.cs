using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportContractprelimmark
    {
        public int ContractPrelimMarkSequenceId { get; set; }
        public int ContractId { get; set; }
        public string Contract { get; set; }
        public string Phase { get; set; }
        public string List { get; set; }
        public DateTime? ListRequiredDate { get; set; }
        public string ContractDescription { get; set; }
        public string ListingName { get; set; }
        public int ItemId { get; set; }
        public string Item { get; set; }
        public string ItemDescription { get; set; }
        public string SectionType { get; set; }
        public string Grade { get; set; }
        public double Quantity { get; set; }
        public double MarkQuantity { get; set; }
        public double QuantityOrdered { get; set; }
        public double QuantityAllocated { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public double Depth { get; set; }
        public int IgnoreForProcurement { get; set; }
        public DateTime? ReleasedOn { get; set; }
        public string ReleasedBy { get; set; }
        public int? EdifileId { get; set; }
        public string EdiBatchNumber { get; set; }
        public string PrelimItemStatus { get; set; }
    }
}

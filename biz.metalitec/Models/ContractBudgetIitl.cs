using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractBudgetIitl
    {
        public int Ident { get; set; }
        public int? TransactionLineId { get; set; }
        public int? ItemTransactionTypeId { get; set; }
        public int? LineTypeId { get; set; }
        public bool? IsIntoInventory { get; set; }
        public int? ContractId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Length { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Area { get; set; }
        public decimal? Value { get; set; }
        public bool? ProRated { get; set; }
        public DateTime InsertedDate { get; set; }
        public int? KeyContractId { get; set; }
    }
}

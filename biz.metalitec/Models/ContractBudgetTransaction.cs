using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractBudgetTransaction
    {
        public int ContractBudgetTransactionId { get; set; }
        public int ContractBudgetId { get; set; }
        /// <summary>
        /// ~1 = PurchaseOrderLine, 2 = InventoryLine, 3 = ManualPosting, 4 = EmployeeTimesheetLine, 5 = SalesOrderLine
        /// </summary>
        public byte BudgetTransactionTypeId { get; set; }
        public int? BudgetTransactionId { get; set; }
        public string Name { get; set; }
        public int? CostCodeId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public double? Value { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public double? Hours { get; set; }
        public string PostingReason { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int Version { get; set; }
        public int? CurrencyId { get; set; }
        public double? ExchangeRate { get; set; }
        public DateTime? ExchangeRateDate { get; set; }

        public virtual ContractBudget ContractBudget { get; set; }
    }
}

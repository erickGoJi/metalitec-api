using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractBudget
    {
        public ContractBudget()
        {
            ContractBudgetLines = new HashSet<ContractBudgetLine>();
            ContractBudgetTransactions = new HashSet<ContractBudgetTransaction>();
        }

        public int ContractBudgetId { get; set; }
        public int ContractId { get; set; }
        /// <summary>
        /// Name of the Budget
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Date of the budget.
        /// </summary>
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Is this budget the master budget?
        /// </summary>
        public bool? IsMasterBudget { get; set; }
        public byte BudgetPeriodTypeId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public int Version { get; set; }
        public string Notes { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual ICollection<ContractBudgetLine> ContractBudgetLines { get; set; }
        public virtual ICollection<ContractBudgetTransaction> ContractBudgetTransactions { get; set; }
    }
}

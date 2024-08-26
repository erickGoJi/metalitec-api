using biz.erpmet.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biz.erpmet.Repository.FinancialReport
{
    public interface IFinancialReportRepository : IGenericRepository<CtbCuenta>
    {
        Task<ActionResult> GetStateResult(string path);
        Task<ActionResult> GetMainAccountEvaluation(string path);
        Task<ActionResult> GetBalanceSheetSummary(string path);
        Task<ActionResult> GetFundingInvestmentOperations(string path);
        Task<ActionResult> GetCashFlow(string path);
        Task<ActionResult> GetOperatingResultsSummary(string path);
        Task<List<BudgetAdvance>> GetBudgetAdvance(string path);
    }
}

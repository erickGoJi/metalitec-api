using System.Collections.Generic;
using System.Threading.Tasks;
using biz.metalitec.Entities;
using Microsoft.AspNetCore.Mvc;

namespace biz.metalitec.Repository.ProductionWorkOrderContract
{
    public interface IProductionWorkOrderContractRepository : IGenericRepository<Models.ProductionWorkOrderContract>
    {
        Task<ActionResult> GetSupplierAssemblers(string path);
        Task<ActionResult> GetAssemblyReleasedOnSite(string path);
        Task<List<AdvanceBudgetTotal>> GetAdvanceBudget();
    }
}
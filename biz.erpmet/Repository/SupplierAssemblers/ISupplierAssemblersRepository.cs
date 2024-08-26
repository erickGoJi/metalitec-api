using System.Threading.Tasks;
using biz.erpmet.Model;
using Microsoft.AspNetCore.Mvc;

namespace biz.erpmet.Repository.SupplierAssemblers
{
    public interface ISupplierAssemblersRepository : IGenericRepository<AcProveedore>
    {
        Task<ActionResult> GetTop(string path);
        Task<ActionResult> GetVariationBudget(string path);
        Task<ActionResult> GetPaymentsAssembly(string path);
    }
}
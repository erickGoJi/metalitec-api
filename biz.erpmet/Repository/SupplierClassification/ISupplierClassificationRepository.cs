using System.Collections.Generic;
using System.Threading.Tasks;
using biz.erpmet.Model;
using Microsoft.AspNetCore.Mvc;

namespace biz.erpmet.Repository.SupplierClassification
{
    public interface ISupplierClassificationRepository :IGenericRepository<AcProveedore>
    {
        Task<ActionResult> GetTopSuppliers(string path);
        Task<ActionResult> GetMaterialsFamily(string path);
        Task<ActionResult> GetPurchaseHistory(string path);
        Task<ActionResult> GetPriceTrend(string path);
        Task<int> GetSupplierCount(string path);
        Task<List<Proyecto>> GetProjectsList(string path);
    }
}
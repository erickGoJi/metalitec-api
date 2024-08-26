using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using biz.erpmet.Model;
using biz.erpmet.Repository.SupplierClassification;
using dal.erpmet.DBContext;
using dal.erpmet.Repository.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using OfficeOpenXml;

namespace dal.erpmet.Repository.SupplierClassification
{
    public class SupplierClassificationRepository : GenericRepository<AcProveedore>, ISupplierClassificationRepository
    {
        public SupplierClassificationRepository(ERPMETContext context):base(context){}
        public async Task<ActionResult> GetTopSuppliers(string path)
        {
            string fileReadAllText = File.ReadAllText(Path.GetFullPath("SQL/004-Top.sql"));
            var topProveedors = await _context.TopProveedors.FromSqlRaw(fileReadAllText).ToListAsync();
            FileInfo fileInfo = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = excel.Workbook.Worksheets.First();
            worksheet.Cells["A:A"].Clear();
            worksheet.Cells["B:B"].Clear();
            worksheet.Cells["C:C"].Clear();
            worksheet.Cells["D:D"].Clear();
            worksheet.Cells["E:E"].Clear();
            worksheet.Cells["F:F"].Clear();
            worksheet.Cells["G:G"].Clear();
            worksheet.Cells["H:H"].Clear();
            worksheet.Cells["I:I"].Clear();
            worksheet.Cells["J:J"].Clear();
            worksheet.Cells["K:K"].Clear();
            worksheet.Cells["L:L"].Clear();
            worksheet.Cells["M:M"].Clear();
            worksheet.Cells["N:N"].Clear();
            worksheet.Cells["O:O"].Clear();
            worksheet.Cells["P:P"].Clear();
            worksheet.Cells["Q:Q"].Clear();
            worksheet.Cells["A1"].LoadFromCollection(topProveedors,true);
            await excel.SaveAsync();
            
            return new ObjectResult(topProveedors);
        }

        public async Task<ActionResult> GetMaterialsFamily(string path)
        {
            // var familyMaterials = await (from a in _context.AcProveedoresXmls
            //     join aa in _context.AcFacturasProveedores on a.IdXmlproveedor equals aa.IdXmlproveedor
            //     join b in _context.AcPedidos on aa.IdProveedor equals b.IdProveedor
            //     join c in _context.AcPedidosDets on b.IdPedido equals c.IdPedido
            //     join cc in _context.AcRequisicionDets on b.IdRequisicion equals cc.IdRequisicion
            //     join d in _context.AcExplosionInsumos on cc.IdExplosionInsumos equals d.IdExplosionInsumos
            //     join e in _context.AcCatInsumos on d.IdInsumo equals e.IdInsumo
            //     join f in _context.AcFamilias on e.IdFamilia equals f.IdFamilia
            //     join g in _context.AcTiposInsumos on e.IdTipoInsumo equals g.IdTipoInsumo 
            //     where b.FechaPedido.Year == DateTime.Now.Year
            //     orderby b.FechaPedido 
            //     select new
            //     {
            //         RazonSocial = a.RazonSocialEmisor,
            //         g.Descripcion,
            //         e.Insumo,
            //         e.IdInsumo,
            //         Costo  = c.CostoNeto,
            //         FechaPedido = b.FechaPedido.ToString("MM/dd/yyyy"),
            //         aa.IdProveedor,
            //         b.IdProyecto,
            //         e.DescripcionLarga,
            //         a.Rfcemisor
            //     }).ToListAsync();
            
            string fileReadAllText = File.ReadAllText(Path.GetFullPath("SQL/FamiliaMateriales.sql"));
            var familyMaterials = await _context.FamilyMaterials.FromSqlRaw(fileReadAllText).ToListAsync();
            FileInfo fileInfo = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = excel.Workbook.Worksheets.First();
            worksheet.Cells["A1:Q10000"].Clear();
            worksheet.Cells["A1"].LoadFromCollection(familyMaterials,true);
            worksheet.Cells["C:C"].Style.Numberformat.Format = "MM/dd/yyyy hh:mm:ss AM/PM";
            await excel.SaveAsync();
            return new ObjectResult(familyMaterials.Take(5));
        }

        public async Task<ActionResult> GetPurchaseHistory(string path)
        {
            // var purchaseHistory = await (from a in _context.AcProveedoresXmls
            //     join aa in _context.AcFacturasProveedores on a.IdXmlproveedor equals aa.IdXmlproveedor
            //     join b in _context.AcPedidos on aa.IdProveedor equals b.IdProveedor
            //     join c in _context.AcRequisicionDets on b.IdRequisicion equals c.IdRequisicion
            //     join d in _context.AcExplosionInsumos on c.IdExplosionInsumos equals d.IdExplosionInsumos
            //     join e in _context.AcCatInsumos on d.IdInsumo equals e.IdInsumo
            //     join f in _context.AcFamilias on e.IdFamilia equals f.IdFamilia
            //     join g in _context.AcTiposInsumos on e.IdTipoInsumo equals g.IdTipoInsumo
            //     where b.FechaPedido.Year == DateTime.Now.Year
            //     select new
            //     {
            //         RazonSocial =  a.RazonSocialEmisor,
            //         Tipo = g.Descripcion,
            //         e.Insumo,
            //         FechaPedido = b.FechaPedido.ToString("MM/dd/yyyy"),
            //         aa.IdProveedor,
            //         b.IdProyecto,
            //         e.Descripcion,
            //         e.DescripcionLarga,
            //         e.IdInsumo
            //     }).ToListAsync();

            string fileReadAllText = File.ReadAllText(Path.GetFullPath("SQL/HistorialCompras.sql"));
            var purchaseHistories = await _context.PurchaseHistories.FromSqlRaw(fileReadAllText).ToListAsync();
            FileInfo fileInfo = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = excel.Workbook.Worksheets.First();
            worksheet.Cells["A:A"].Clear();
            worksheet.Cells["B:B"].Clear();
            worksheet.Cells["C:C"].Clear();
            worksheet.Cells["D:D"].Clear();
            worksheet.Cells["E:E"].Clear();
            worksheet.Cells["F:F"].Clear();
            worksheet.Cells["G:G"].Clear();
            worksheet.Cells["H:H"].Clear();
            worksheet.Cells["I:I"].Clear();
            worksheet.Cells["J:J"].Clear();
            worksheet.Cells["K:K"].Clear();
            worksheet.Cells["L:L"].Clear();
            worksheet.Cells["M:M"].Clear();
            worksheet.Cells["N:N"].Clear();
            worksheet.Cells["O:O"].Clear();
            worksheet.Cells["P:P"].Clear();
            worksheet.Cells["Q:Q"].Clear();
            worksheet.Cells["A1"].LoadFromCollection(purchaseHistories,true);
            worksheet.Column(4).Style.Numberformat.Format  = "yyyy-mm-dd";
            await excel.SaveAsync();
            return new ObjectResult(purchaseHistories.Take(10));
        }

        public async Task<int> GetSupplierCount(string path)
        {
            var suppliers = _context.AcProveedores.Count(c=> c.AcFacturasProveedores.Any(a=>a.IdProyecto >= 1190));
            List<Proveedor> proveedors = new List<Proveedor>();
            proveedors.Add(new Proveedor()
            {
                Proveedores = suppliers
            });
            FileInfo fileInfo = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = excel.Workbook.Worksheets.First();
            worksheet.Cells["A:A"].Clear();
            worksheet.Cells["B:B"].Clear();
            worksheet.Cells["C:C"].Clear();
            worksheet.Cells["D:D"].Clear();
            worksheet.Cells["E:E"].Clear();
            worksheet.Cells["F:F"].Clear();
            worksheet.Cells["G:G"].Clear();
            worksheet.Cells["H:H"].Clear();
            worksheet.Cells["I:I"].Clear();
            worksheet.Cells["J:J"].Clear();
            worksheet.Cells["K:K"].Clear();
            worksheet.Cells["L:L"].Clear();
            worksheet.Cells["M:M"].Clear();
            worksheet.Cells["N:N"].Clear();
            worksheet.Cells["O:O"].Clear();
            worksheet.Cells["P:P"].Clear();
            worksheet.Cells["Q:Q"].Clear();
            worksheet.Cells["A1"].LoadFromCollection(proveedors,true);
            await excel.SaveAsync();
            return suppliers;
        }

        public async Task<List<Proyecto>> GetProjectsList(string path)
        {
            var projects = _context.Proyectos.Where(x=>x.IdProyecto >= 1190).ToList();
            FileInfo fileInfo = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = excel.Workbook.Worksheets.First();
            worksheet.Cells["A:A"].Clear();
            worksheet.Cells["B:B"].Clear();
            worksheet.Cells["C:C"].Clear();
            worksheet.Cells["D:D"].Clear();
            worksheet.Cells["E:E"].Clear();
            worksheet.Cells["F:F"].Clear();
            worksheet.Cells["G:G"].Clear();
            worksheet.Cells["H:H"].Clear();
            worksheet.Cells["I:I"].Clear();
            worksheet.Cells["J:J"].Clear();
            worksheet.Cells["K:K"].Clear();
            worksheet.Cells["L:L"].Clear();
            worksheet.Cells["M:M"].Clear();
            worksheet.Cells["N:N"].Clear();
            worksheet.Cells["O:O"].Clear();
            worksheet.Cells["P:P"].Clear();
            worksheet.Cells["Q:Q"].Clear();
            worksheet.Cells["A1"].LoadFromCollection(projects.OrderByDescending(o=>o.IdProyecto),true);
            await excel.SaveAsync();
            return projects;
        }

        private class Proveedor
        {
            public int Proveedores { get; set; }   
        }

        public async Task<ActionResult> GetPriceTrend(string path)
        {
            // var priceTrend = await (from a in _context.AcProveedoresXmls
            //     join aa in _context.AcFacturasProveedores on a.IdXmlproveedor equals aa.IdXmlproveedor
            //     join b in _context.AcPedidos on aa.IdProveedor equals b.IdProveedor
            //     join c in _context.AcPedidosDets on b.IdPedido equals c.IdPedido
            //     join dd in _context.AcRequisicionDets on b.IdRequisicion equals dd.IdRequisicion
            //     join d in _context.AcExplosionInsumos on dd.IdExplosionInsumos equals d.IdExplosionInsumos
            //     join e in _context.AcCatInsumos on d.IdInsumo equals e.IdInsumo
            //     join f in _context.AcFamilias on e.IdFamilia equals f.IdFamilia
            //     join g in _context.AcTiposInsumos on e.IdTipoInsumo equals g.IdTipoInsumo
            //     where b.FechaPedido.Year == DateTime.Now.Year
            //     select new
            //     {
            //         anio = b.FechaPedido.Year,
            //         mes = b.FechaPedido.Month,
            //         c.Costo,
            //         c.Cantidad,
            //         Tipo = g.Descripcion,
            //         e.Insumo,
            //         e.DescripcionLarga,
            //         e.IdInsumo
            //     }).ToListAsync();
            string fileReadAllText = File.ReadAllText(Path.GetFullPath("SQL/PrecioTendencia.sql"));
            var priceTrends = await _context.PriceTrends.FromSqlRaw(fileReadAllText).ToListAsync();
            FileInfo fileInfo = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = excel.Workbook.Worksheets.First();
            worksheet.Cells["A:A"].Clear();
            worksheet.Cells["B:B"].Clear();
            worksheet.Cells["C:C"].Clear();
            worksheet.Cells["D:D"].Clear();
            worksheet.Cells["E:E"].Clear();
            worksheet.Cells["F:F"].Clear();
            worksheet.Cells["G:G"].Clear();
            worksheet.Cells["H:H"].Clear();
            worksheet.Cells["I:I"].Clear();
            worksheet.Cells["J:J"].Clear();
            worksheet.Cells["K:K"].Clear();
            worksheet.Cells["L:L"].Clear();
            worksheet.Cells["M:M"].Clear();
            worksheet.Cells["N:N"].Clear();
            worksheet.Cells["O:O"].Clear();
            worksheet.Cells["P:P"].Clear();
            worksheet.Cells["Q:Q"].Clear();
            worksheet.Cells["A1"].LoadFromCollection(priceTrends,true);
            await excel.SaveAsync();
            return new ObjectResult(priceTrends);
        }
    }
}
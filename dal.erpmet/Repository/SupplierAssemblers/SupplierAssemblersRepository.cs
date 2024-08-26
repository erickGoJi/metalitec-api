using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using biz.erpmet.Model;
using biz.erpmet.Repository.SupplierAssemblers;
using dal.erpmet.DBContext;
using dal.erpmet.Repository.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using OfficeOpenXml;

namespace dal.erpmet.Repository.SupplierAssemblers
{
    public class SupplierAssemblersRepository : GenericRepository<AcProveedore>, ISupplierAssemblersRepository
    {
        public SupplierAssemblersRepository(ERPMETContext context):base(context){}
        public async Task<ActionResult> GetTop(string path)
        {
            string fileReadAllText = await File.ReadAllTextAsync(Path.GetFullPath("SQL/Top5kilosMontados.sql"));
            var kilosMountings= await _context.Top5KilosMountings.FromSqlRaw(fileReadAllText).ToListAsync();
            FileInfo fileInfo = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = excel.Workbook.Worksheets.First();
            worksheet.Cells["A1:G10"].Clear();
            worksheet.Cells["A1"].LoadFromCollection(kilosMountings,true);
            await excel.SaveAsync();
            return new ObjectResult(kilosMountings);
        }

        public async Task<ActionResult> GetVariationBudget(string path)
        {
            var variationBudget = (from a in _context.AoPresupuestoControls
                join b in _context.Proyectos on a.IdProyecto equals b.IdProyecto
                where a.IdProyecto > 1189
                group a by new {a.IdProyecto, b.Proyecto1}
                into s
                select new
                {
                    s.Key.IdProyecto,
                    s.Key.Proyecto1,
                    varficacion = s.Sum(q => (q.CantidadOriginal + q.CantidadOc) * q.CostoGlobalActual),
                    presupuesto = s.Sum(q => q.CantidadOriginalImportada + q.CostoOriginalImportado)
                }).ToList();
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
            worksheet.Cells["A1"].LoadFromCollection(variationBudget,true);
            await excel.SaveAsync();
            return new ObjectResult(variationBudget);
        }

        public async Task<ActionResult> GetPaymentsAssembly(string path)
        {
            string[] familias = new[] {"SUEME", "SUESP"};
            var paymentsAssembly = (from a in _context.AcProveedores
                join b in _context.AcFacturasProveedores on a.IdProveedor equals b.IdProveedor
                join c in _context.AcFacturasProveedoresDets on b.IdFacturaProveedor equals c.IdFacturaProveedor
                join e in _context.AcExplosionInsumos on c.IdExplosionInsumos equals e.IdExplosionInsumos
                join f in _context.AcCatInsumos on e.IdInsumo equals f.IdInsumo
                join g in _context.AcFamilias on f.IdFamilia equals g.IdFamilia
                join h in _context.AcBancosEgresos on a.Rfc equals h.RfcBeneficiario
                join i in _context.Proyectos on b.IdProyecto equals i.IdProyecto
                where familias.Contains(g.Familia) && b.IdProyecto > 1189
                group c by new {b.IdProyecto, i.Proyecto1, b.IdProveedor, a.RazonSocial, c.Cantidad }
                into s
                orderby s.Key.IdProyecto, s.Key.Cantidad
                select new
                {
                    s.Key.IdProyecto,
                    s.Key.Proyecto1,
                    s.Key.IdProveedor,
                    s.Key.RazonSocial,
                    Montaje = s.Sum(q => q.Cantidad),
                    Pagos = s.Sum(c => c.Cantidad + c.Costo)
                }).ToList();
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
            worksheet.Cells["A1"].LoadFromCollection(paymentsAssembly,true);
            await excel.SaveAsync();
            return new ObjectResult(paymentsAssembly);
        }
    }
}
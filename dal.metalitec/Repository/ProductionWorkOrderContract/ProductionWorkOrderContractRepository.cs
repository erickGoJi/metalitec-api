using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using biz.metalitec.Entities;
using biz.metalitec.Models;
using biz.metalitec.Repository.ProductionWorkOrderContract;
using dal.metalitec.DBContext;
using dal.metalitec.Repository.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using OfficeOpenXml;
using LicenseContext = System.ComponentModel.LicenseContext;

namespace dal.metalitec.Repository.ProductionWorkOrderContract
{
    public class ProductionWorkOrderContractRepository : GenericRepository<biz.metalitec.Models.ProductionWorkOrderContract>, IProductionWorkOrderContractRepository
    {
        public ProductionWorkOrderContractRepository(AcecadContext context) : base(context)
        {
            
        }

        public async Task<ActionResult> GetSupplierAssemblers(string path)
        {
            string fileReadAllText = await File.ReadAllTextAsync(Path.GetFullPath("SQL/MontajePrograma.sql"));
            var programMountings = _context.ProgramMountings.FromSqlRaw(fileReadAllText).ToList();
            FileInfo fileInfo = new FileInfo(path);
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = excel.Workbook.Worksheets.First();
            worksheet.Cells["A:A"].Clear();
            worksheet.Cells["B:B"].Clear();
            worksheet.Cells["C:C"].Clear();
            worksheet.Cells["D:D"].Clear();
            worksheet.Cells["E:E"].Clear();
            worksheet.Cells["F:F"].Clear();
            worksheet.Cells["G:G"].Clear();
            worksheet.Cells["A1"].LoadFromCollection(programMountings,true);
            await excel.SaveAsync();
            return new ObjectResult(programMountings);
        }
        
        public async Task<ActionResult> GetAssemblyReleasedOnSite(string path)
        {
            string fileReadAllText = await File.ReadAllTextAsync(Path.GetFullPath("SQL/MontajeLiberadoObra.sql"));
            var assemblyReleasedOnSite = await _context.AssemblyReleasedOnSites.FromSqlRaw(fileReadAllText).ToListAsync();
            FileInfo fileInfo = new FileInfo(path);
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = excel.Workbook.Worksheets.First();
            worksheet.Cells["A:A"].Clear();
            worksheet.Cells["B:B"].Clear();
            worksheet.Cells["C:C"].Clear();
            worksheet.Cells["D:D"].Clear();
            worksheet.Cells["E:E"].Clear();
            worksheet.Cells["F:F"].Clear();
            worksheet.Cells["G:G"].Clear();
            worksheet.Cells["A1"].LoadFromCollection(assemblyReleasedOnSite,true);
            await excel.SaveAsync();
            return new ObjectResult(assemblyReleasedOnSite);
        }

        public async Task<List<AdvanceBudgetTotal>> GetAdvanceBudget()
        {
            var totals = _context.AdvanceBudgetTotals.FromSqlRaw("select cast(sum(aaa.Weight) as decimal(16,2))[Total],"+
             "aaa.ProjectID[ProjectID], p.Name[Name] " +
             "from Contract aaa " +
             "inner join Project p on aaa.ProjectID = p.ProjectID " +
             "where aaa.ProjectID > 39 " +
             "group by aaa.ProjectID, p.Name").ToList();
            List<AdvanceBudgetTotal> budgetTotals = new List<AdvanceBudgetTotal>();
            foreach (var total in totals)
            {
                budgetTotals.Add(new AdvanceBudgetTotal()
                {
                    ProjectID = total.ProjectID,
                    Name = total.Name,
                    Total = total.Total
                });
            }

            return budgetTotals;
        }

        private static double ReturnSum(List<double> montajeMist)
        {
            return montajeMist.Sum(s => s);
        }
    }
}
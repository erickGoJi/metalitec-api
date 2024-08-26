using biz.erpmet.Model;
using biz.erpmet.Repository.FinancialReport;
using dal.erpmet.DBContext;
using dal.erpmet.Repository.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biz.erpmet.Entities;
using biz.erpmet.Repository;
using Ganss.Excel;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace dal.erpmet.Repository.FinancialReport
{
    public class FinancialReportRepository : GenericRepository<CtbCuenta>, IFinancialReportRepository
    {
        public FinancialReportRepository(ERPMETContext context) : base(context) { }

        public async Task<ActionResult> GetStateResult(string path)
        {
            
            string fileReadAllText = File.ReadAllText(Path.GetFullPath("SQL/Estado de Resultados.sql"));
            List<IncomeStatement> incomeStatements = await _context.IncomeStatements
                .FromSqlRaw(fileReadAllText)
                .ToListAsync();
            var onlyZero = incomeStatements
                .Where(x => x.Costo == 0 && x.Ingresos == 0 && x.Gastos == 0 && x.UtilidadNeta == 0).ToList();
            FileInfo fileInfo = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = excel.Workbook.Worksheets.First();
            worksheet.Cells["A1:J1000"].Clear();
            worksheet.Cells["A1"].LoadFromCollection(incomeStatements.Where(x=> !onlyZero.Contains(x)).ToList(),true);
            worksheet.Cells["A1:AP1"].AutoFilter = true;

            await excel.SaveAsync();

            return new ObjectResult(incomeStatements.OrderBy(o => o.mes));
        }

        public async Task<ActionResult> GetMainAccountEvaluation(string path)
        {   
            FileInfo info = new FileInfo(Path.GetFullPath("SQL/EvolucionDeCuentas.sql"));
            string fileReadAllText = File.ReadAllText(Path.GetFullPath("SQL/EvolucionDeCuentas.sql"));
            FileStream fileStream = info.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            byte[] fileBytes = new byte[fileStream.Length];
            int numBytesToRead = (int)fileBytes.Length;
            int numBytesRead = 0;
            while (numBytesToRead > 0)
            {
                int n = fileStream.Read(fileBytes, numBytesRead, numBytesToRead);
        
                if (n == 0)
                    break;

                numBytesRead += n;
                numBytesToRead -= n;
            }
            string filestring = Convert.ToString(fileBytes);
            string anotherString = ConvertToString(fileBytes);
            var mainAccountsBalance = _context.MainAccountEvaluations.FromSqlRaw(fileReadAllText).ToList();
            
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
            worksheet.Cells["A1"].LoadFromCollection(mainAccountsBalance,true);
            await excel.SaveAsync();
            return new ObjectResult(mainAccountsBalance.OrderBy(o => o.Mes));
        }

        public async Task<ActionResult> GetBalanceSheetSummary(string path)
        {
            string fileReadAllText = await File.ReadAllTextAsync(Path.GetFullPath("SQL/ResumenBalanceGeneral.sql"));
            
            var balanceSheetSummaries = _context.BalanceSheetSummaries.FromSqlRaw(fileReadAllText).ToList();
            

            FileInfo fileInfo = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = excel.Workbook.Worksheets.First();
            worksheet.Cells["A1:G400"].Clear();
            worksheet.Cells["A1"].LoadFromCollection(balanceSheetSummaries,true);
            await excel.SaveAsync();
            return new ObjectResult(balanceSheetSummaries.OrderBy(o => o.Mes).Take(5));
        }
        private string ConvertToString(byte[] data)
        {
            char[] characters = data.Select(b => (char)b).ToArray();
            return new string(characters);
        }
        public static string RemoveControlCharacters(string inString)
        {
            if (inString == null) return null;
            StringBuilder newString = new StringBuilder();
            char ch;
            for (int i = 0; i < inString.Length; i++)
            {
                ch = inString[i];
                if (!char.IsControl(ch))
                {
                    newString.Append(ch);
                }
            }
            return newString.ToString();
        }

        public async Task<ActionResult> GetFundingInvestmentOperations(string path)
        {
            string fileReadAllText = await File.ReadAllTextAsync(Path.GetFullPath("SQL/FondeoOperaciones.sql"));
            
            var fundingInvestmentOperations = _context.FundingInvestmentOperations.FromSqlRaw(fileReadAllText).ToList();
            
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
            worksheet.Cells["A1"].LoadFromCollection(fundingInvestmentOperations,true);
            worksheet.Cells["G:G"].Style.Numberformat.Format = "yyyy-mm-dd h:mm";
            await excel.SaveAsync();
            return new ObjectResult(fundingInvestmentOperations.OrderBy(o => o.Mes));
        }

        public async Task<ActionResult> GetCashFlow(string path)
        {
            string fileReadAllText = await File.ReadAllTextAsync(Path.GetFullPath("SQL/FlujoEfectivo.sql"));
            var cashFlowList = await _context.CashFlows.FromSqlRaw(fileReadAllText).ToListAsync();
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month - 3;
            DateTime dateMin30 = DateTime.Now.AddDays(-30);
            DateTime dateMax90 = DateTime.Now.AddDays(-90);
            List<CashFlowData> cashFlowDatas = new List<CashFlowData>();
            string[] actions = new[]
            {
                "CargoCuentaClientesAnticpos", 
                "CargoCuentaClientesAnticposPedidos", 
                "AbonoCuentaProveedorAnticipos", 
                "AbonoCuentaProveedorEstimacionPedidos", 
                "Pagado",
                "PagadoTraladado",
                "MayorTresMeses"
            };

            foreach (var cashFlow in cashFlowList)
            {
                string actionValue = "";
                string category = "";
                decimal amount = 0;
                decimal abonoAnticipo = cashFlow.AbonoCuentaProveedorAnticipos;
                decimal abonoPedido = cashFlow.AbonoCuentaProveedorEstimacionPedidos;
                decimal cargoAnticipos = cashFlow.CargoCuentaClientesAnticpos;
                decimal cargoPedidos = cashFlow.CargoCuentaClientesAnticposPedidos;
                decimal o = cashFlow.Pagado;

                #region Assign Category

                if (abonoAnticipo != 0 && abonoPedido == 0 && cargoAnticipos == 0 && cargoPedidos == 0)
                {
                    category = "Egreso";
                } 
                else if (abonoAnticipo == 0 && abonoPedido != 0 && cargoAnticipos == 0 && cargoPedidos == 0)
                {
                    category = "Egreso";
                } 
                else if (abonoAnticipo == 0 && abonoPedido == 0 && cargoAnticipos != 0 && cargoPedidos == 0)
                {
                    category = "Ingreso";
                } 
                else if (abonoAnticipo == 0 && abonoPedido == 0 && cargoAnticipos == 0 && cargoPedidos != 0)
                {
                    category = "Ingreso";
                }

                #endregion
                
                // Pago Trasladado
                // MAYOR A 30 AND MINOR 90
                if (cashFlow.FechaFactura >= dateMax90 && cashFlow.FechaFactura <= dateMin30 && cashFlow.Pagado != 0)
                {
                    actionValue = actions[5];
                    
                    cashFlowDatas.Add(new CashFlowData()
                    {
                        Year = year,
                        Month = DateTime.Now.Month,
                        InvoiceDate = DateTime.Now,
                        Description = cashFlow.Descripcion,
                        IdPolicy = cashFlow.idPoliza,
                        Action = actionValue,
                        Category = category,
                        Amount = o
                    });
                }
                // Mayor Tres Meses
                // MAYOR 90 DIAS
                else if (cashFlow.FechaFactura < dateMax90 && cashFlow.Pagado != 0)
                {
                    actionValue = actions[6];
                    cashFlowDatas.Add(new CashFlowData()
                    {
                        Year = year,
                        Month = DateTime.Now.Month,
                        InvoiceDate = DateTime.Now,
                        Description = cashFlow.Descripcion,
                        IdPolicy = cashFlow.idPoliza,
                        Action = actionValue,
                        Category = category,
                        Amount = cashFlow.Pagado
                    });
                }
                else if (cashFlow.FechaFactura >= dateMin30 && cashFlow.Pagado != 0)
                {
                    actionValue = actions[4];
                    cashFlowDatas.Add(new CashFlowData()
                    {
                        Year = year,
                        Month = DateTime.Now.Month,
                        InvoiceDate = DateTime.Now,
                        Description = cashFlow.Descripcion,
                        IdPolicy = cashFlow.idPoliza,
                        Action = actionValue,
                        Category = category,
                        Amount = cashFlow.Pagado
                    });
                }
                else if(cashFlow.Pagado == 0)
                {
                    if (abonoAnticipo != 0 && abonoPedido == 0 && cargoAnticipos == 0 && cargoPedidos == 0)
                    {
                        actionValue = actions[2];
                        amount = abonoAnticipo;
                    } 
                    else if (abonoAnticipo == 0 && abonoPedido != 0 && cargoAnticipos == 0 && cargoPedidos == 0)
                    {
                        actionValue = actions[3];
                        amount = abonoPedido;
                    } 
                    else if (abonoAnticipo == 0 && abonoPedido == 0 && cargoAnticipos != 0 && cargoPedidos == 0)
                    {
                        actionValue = actions[0];
                        amount = cargoAnticipos;
                    } 
                    else if (abonoAnticipo == 0 && abonoPedido == 0 && cargoAnticipos == 0 && cargoPedidos != 0)
                    {
                        actionValue = actions[1];
                        amount = cargoPedidos;
                    }
                    cashFlowDatas.Add(new CashFlowData()
                    {
                        Year = cashFlow.anio,
                        Month = cashFlow.mes,
                        InvoiceDate = cashFlow.FechaFactura,
                        Description = cashFlow.Descripcion,
                        IdPolicy = cashFlow.idPoliza,
                        Action = actionValue,
                        Category = category,
                        Amount = amount
                    });
                }
            }

            var sigmas = cashFlowDatas
                .GroupBy(x => new
                {
                    Invoice = x.InvoiceDate.ToString("yyyyMMdd")
                })
                .Select(s => new CashFlowData()
            {
                Action = "Ingreso - Egreso",
                Category = "Ingreso - Egreso",
                Amount = s.Where(x=>x.Category.Equals("Ingreso")).Sum(s=>s.Amount) 
                         - s.Where(x=>x.Category.Equals("Egreso")).Sum(s=>s.Amount),
                Description = s.First().Description,
                Month = s.First().Month,
                Year = s.First().Year,
                IdPolicy = s.First().IdPolicy,
                InvoiceDate = s.First().InvoiceDate
            }).ToList();
            cashFlowDatas.AddRange(sigmas);
            List<CashFlow> flows = new List<CashFlow>();
            foreach (var flow in cashFlowList)
            {
                // Pago Trasladado
                // MAYOR A 30 AND MINOR 90
                if (flow.FechaFactura >= dateMax90 && flow.FechaFactura <= dateMin30 && flow.Pagado != 0)
                {
                    decimal abonoAnticipo = flow.AbonoCuentaProveedorAnticipos;
                    decimal abonoPedido = flow.AbonoCuentaProveedorEstimacionPedidos;
                    decimal cargoAnticipos = flow.CargoCuentaClientesAnticpos;
                    decimal cargoPedidos = flow.CargoCuentaClientesAnticposPedidos;
                    decimal o = flow.Pagado;
                    if (abonoAnticipo != 0 && abonoPedido == 0 && cargoAnticipos == 0 && cargoPedidos == 0)
                    {
                        flow.AbonoCuentaProveedorAnticipos = 0;
                    } 
                    else if (abonoAnticipo == 0 && abonoPedido != 0 && cargoAnticipos == 0 && cargoPedidos == 0)
                    {
                        flow.AbonoCuentaProveedorEstimacionPedidos = 0;
                    } 
                    else if (abonoAnticipo == 0 && abonoPedido == 0 && cargoAnticipos != 0 && cargoPedidos == 0)
                    {
                        flow.CargoCuentaClientesAnticpos = 0;
                    } 
                    else if (abonoAnticipo == 0 && abonoPedido == 0 && cargoAnticipos == 0 && cargoPedidos != 0)
                    {
                        flow.CargoCuentaClientesAnticposPedidos = 0;
                    }
                    flows.Add(new CashFlow()
                    {
                        anio = year,
                        mes = DateTime.Now.Month,
                        FechaFactura = DateTime.Now,
                        Descripcion = flow.Descripcion,
                        idPoliza = flow.idPoliza,
                        Pagado = 0,
                        PagadoTrasladado = o,
                        MayorTresMeses = 0,
                        AbonoCuentaProveedorAnticipos = abonoAnticipo,
                        CargoCuentaClientesAnticpos = cargoAnticipos,
                        AbonoCuentaProveedorEstimacionPedidos = abonoPedido,
                        CargoCuentaClientesAnticposPedidos = cargoPedidos
                    });
                }
                // Mayor Tres Meses
                // MAYOR 90 DIAS
                else if (flow.FechaFactura < dateMax90 && flow.Pagado != 0)
                {
                    flow.MayorTresMeses = flow.Pagado;
                    flow.Pagado = 0;
                }
            }

            cashFlowList.AddRange(flows);
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
            worksheet.Cells["A1"].LoadFromCollection(cashFlowDatas,true);
            worksheet.Cells["A:A"].Style.Numberformat.Format = "yyyy-mm-dd h:mm";
            
            var cashFlowListAsync = await _context.CashFlows.FromSqlRaw(fileReadAllText).ToListAsync();
            ExcelWorksheet worksheetSecond = excel.Workbook.Worksheets[1];
            worksheetSecond.Cells["A:A"].Clear();
            worksheetSecond.Cells["B:B"].Clear();
            worksheetSecond.Cells["C:C"].Clear();
            worksheetSecond.Cells["D:D"].Clear();
            worksheetSecond.Cells["E:E"].Clear();
            worksheetSecond.Cells["F:F"].Clear();
            worksheetSecond.Cells["G:G"].Clear();
            worksheetSecond.Cells["H:H"].Clear();
            worksheetSecond.Cells["I:I"].Clear();
            worksheetSecond.Cells["J:J"].Clear();
            worksheetSecond.Cells["K:K"].Clear();
            worksheetSecond.Cells["L:L"].Clear();
            worksheetSecond.Cells["A1"].LoadFromCollection(cashFlowList,true);
            worksheetSecond.Cells["A:A"].Style.Numberformat.Format = "yyyy-mm-dd h:mm";
            
            ExcelWorksheet worksheetThird = excel.Workbook.Worksheets[2];
            worksheetThird.Cells["A:A"].Clear();
            worksheetThird.Cells["B:B"].Clear();
            worksheetThird.Cells["C:C"].Clear();
            worksheetThird.Cells["D:D"].Clear();
            worksheetThird.Cells["E:E"].Clear();
            worksheetThird.Cells["F:F"].Clear();
            worksheetThird.Cells["G:G"].Clear();
            worksheetThird.Cells["H:H"].Clear();
            worksheetThird.Cells["I:I"].Clear();
            worksheetThird.Cells["J:J"].Clear();
            worksheetThird.Cells["K:K"].Clear();
            worksheetThird.Cells["L:L"].Clear();
            worksheetThird.Cells["A1"].LoadFromCollection(cashFlowListAsync,true);
            worksheetThird.Cells["A:A"].Style.Numberformat.Format = "yyyy-mm-dd h:mm";
            await excel.SaveAsync();
            return new ObjectResult(cashFlowList.Take(100));
        }

        public async Task<ActionResult> GetOperatingResultsSummary(string path)
        {
            
            string fileReadAllText = await File.ReadAllTextAsync(Path.GetFullPath("SQL/ResumenResultados.sql"));
            
            var operatingResultsSummaries = _context.OperatingResultsSummaries.FromSqlRaw(fileReadAllText).ToList();
            
            FileInfo fileInfo = new FileInfo(path); 
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage(fileInfo);
            List<OperatingResultsSummaryReturn> resultsSummaryReturns = new List<OperatingResultsSummaryReturn>();
            string year = DateTime.Now.Year.ToString();
            string lastYear = (DateTime.Now.Year - 1).ToString();
            string Month = (DateTime.Now.Month - 1).ToString("d2");
            string lastMonth = (DateTime.Now.Month - 2).ToString("d2");
            foreach (var operatingResultsSummary in operatingResultsSummaries.GroupBy(o=>o.IdProyecto))
            {
                var ia = operatingResultsSummary.FirstOrDefault(f => f.anio == year && f.mes == Month)?.Ingresos;
                var ipm = operatingResultsSummary.FirstOrDefault(f=> f.anio == year && f.mes == lastMonth)?.Ingresos;
                var ily = operatingResultsSummary.FirstOrDefault(f=> f.anio == lastYear && f.mes == Month)?.Ingresos;
                var ea = operatingResultsSummary.FirstOrDefault(f=> f.anio == year && f.mes == Month)?.EBITDA;
                var epm = operatingResultsSummary.FirstOrDefault(f=> f.anio == year && f.mes == lastMonth)?.EBITDA;
                var ely = operatingResultsSummary.FirstOrDefault(f=> f.anio == lastYear && f.mes == Month)?.EBITDA;
                var una = operatingResultsSummary.FirstOrDefault(f=> f.anio == year && f.mes == Month)?.UtilidadNeta;
                var unpm = operatingResultsSummary.FirstOrDefault(f => f.anio == year && f.mes == lastMonth)?.UtilidadNeta;
                var unly = operatingResultsSummary.FirstOrDefault(f=> f.anio == lastYear && f.mes == Month)?.UtilidadNeta;
                var ca = operatingResultsSummary.FirstOrDefault(f=> f.anio == year && f.mes == Month)?.Costos;
                var cpm = operatingResultsSummary.FirstOrDefault(f=> f.anio == year && f.mes == lastMonth)?.Costos;
                var cly = operatingResultsSummary.FirstOrDefault(f=> f.anio == lastYear && f.mes == Month)?.Costos;
                var uba = operatingResultsSummary.FirstOrDefault(f=> f.anio == year && f.mes == Month)?.UtilidadBruta;
                var ubpm = operatingResultsSummary.FirstOrDefault(f => f.anio == year && f.mes == lastMonth)?.UtilidadBruta;
                var ubly = operatingResultsSummary.FirstOrDefault(f=> f.anio == lastYear && f.mes == Month)?.UtilidadBruta;
                var ga = operatingResultsSummary.FirstOrDefault(f=> f.anio == year && f.mes == Month)?.Gastos;
                var gpm = operatingResultsSummary.FirstOrDefault(f => f.anio == year && f.mes == lastMonth)?.Gastos;
                var gly = operatingResultsSummary.FirstOrDefault(f=> f.anio == lastYear && f.mes == Month)?.Gastos;
                var da = operatingResultsSummary.FirstOrDefault(f=> f.anio == year && f.mes == Month)?.Depreciacion;
                var dpm = operatingResultsSummary.FirstOrDefault(f => f.anio == year && f.mes == lastMonth)?.Depreciacion;
                var dly = operatingResultsSummary.FirstOrDefault(f=> f.anio == lastYear && f.mes == Month)?.Depreciacion;
                var ina = operatingResultsSummary.FirstOrDefault(f=> f.anio == year && f.mes == Month)?.Interes;
                var inpm = operatingResultsSummary.FirstOrDefault(f => f.anio == year && f.mes == lastMonth)?.Interes;
                var inly = operatingResultsSummary.FirstOrDefault(f=> f.anio == lastYear && f.mes == Month)?.Interes;
                resultsSummaryReturns.Add(new OperatingResultsSummaryReturn()
                {
                    anio = operatingResultsSummary.First().anio,
                    mes = operatingResultsSummary.First().mes,
                    Proyecto = operatingResultsSummary.First().Proyecto,
                    IdProyecto = operatingResultsSummary.First().IdProyecto,
                    IngresosActual = ia,
                    IngresosPreviousMonth = ipm,
                    IngresosLastYear = ily,
                    CostosActual = ca,
                    CostosPreviousMonth = cpm,
                    CostosLastYear = cly,
                    UtilidadBrutaActual = uba,
                    UtilidadBrutaPreviousMonth = ubpm,
                    UtilidadBrutaLastYear = ubly,
                    GastosActual = ga,
                    GastosPreviousMonth = gpm,
                    GastosLastYear = gly,
                    EBITDAActual = ea,
                    EBITDAPreviousMonth = epm,
                    EBITDALastYear = ely,
                    EBITDAPercentageActual = ValidateValues(ia, ea) ? ea / ia: 0,
                    EBITDAPercentagePreviousMonth = ValidateValues(ipm, epm) ? epm / ipm: 0,
                    EBITDAPercentageLastYear = ValidateValues(ily, ely) ? ely / ily: 0,
                    DepreciacionActual = da,
                    DepreciacionPreviousMonth = dpm,
                    DepreciacionLastYear = dly,
                    InteresActual = ina,
                    InteresPreviousMonth = inpm,
                    InteresLastYear = inly,
                    UtilidadNetaActual = una,
                    UtilidadNetaPreviousMonth = unpm,
                    UtilidadNetaLastYear = unly,
                    UtilidadNetaPercentageActual = ValidateValues(ia, una) ? una / ia : 0,
                    UtilidadNetaPercentagePreviousMonth = ValidateValues(ipm, unpm) ? unpm / ipm: 0,
                    UtilidadNetaPercentageLastYear = ValidateValues(ely, unly) ? unly / ely: 0
                });
            }

            foreach (var @return in resultsSummaryReturns)
            {
                @return.YOYIngresos = ValidateValues(@return.IngresosActual, @return.IngresosLastYear) ? (@return
                    .IngresosActual / @return.IngresosLastYear) - 1 : 0;
                @return.YOYCostosVentas = ValidateValues(@return.CostosActual, @return.CostosLastYear) ? (@return
                    .CostosActual / @return.CostosLastYear) - 1 : 0;
                @return.YOYUtilidadBruta = ValidateValues(@return.UtilidadBrutaActual, @return.UtilidadBrutaLastYear) ? (
                    @return.UtilidadBrutaActual / @return.UtilidadBrutaLastYear) - 1 : 0;
                @return.YOYEBITDA = ValidateValues(@return.EBITDAPercentageActual, @return.EBITDAPercentageLastYear) ? (
                    @return.EBITDAPercentageActual / @return.EBITDAPercentageLastYear) - 1 : 0;
                @return.YOYUtilidadNeta = ValidateValues(@return.UtilidadNetaActual, @return.UtilidadNetaLastYear) ? (
                    @return.UtilidadNetaActual / @return.UtilidadNetaLastYear) - 1 : 0;
                @return.MOMIngresos = ValidateValues(@return.IngresosActual, @return.IngresosPreviousMonth) ? (@return
                    .IngresosActual / @return.IngresosPreviousMonth) - 1 : 0;
                @return.MOMUtilidadNeta = ValidateValues(@return.UtilidadNetaPercentageActual, @return.UtilidadNetaPercentagePreviousMonth)
                    ? (@return.UtilidadNetaPercentageActual / @return.UtilidadNetaPercentagePreviousMonth) - 1
                    : 0;
                @return.MOMEBITDA = ValidateValues(@return.EBITDAPercentageActual, @return.EBITDAPercentageLastYear) ? (
                    @return.EBITDAPercentageActual / @return.EBITDAPercentageLastYear) - 1 : 0;
            }
            ExcelWorksheet worksheet = excel.Workbook.Worksheets[0];
            worksheet.Cells["A:AP"].Clear();
            worksheet.Cells["A1"].LoadFromCollection(resultsSummaryReturns, true);
            worksheet.Cells["A1:AP1"].AutoFilter = true;
            ExcelWorksheet worksheetSecond = excel.Workbook.Worksheets[1];
            worksheetSecond.Cells["A:AP"].Clear();
            worksheetSecond.Cells["A1"].LoadFromCollection(operatingResultsSummaries, true);
            worksheetSecond.Cells["A1:AP1"].AutoFilter = true;
            ExcelWorksheet worksheetThird = excel.Workbook.Worksheets[2];
            worksheetThird.Cells["A:H"].Clear();
            //Headers
            worksheetThird.Cells["A1"].Value = "Concepto";
            worksheetThird.Cells["B1"].Value = "Mes Actual 21' R";
            worksheetThird.Cells["C1"].Value = "Mes Anterior' 20 R";
            worksheetThird.Cells["D1"].Value = "y-o-y";
            worksheetThird.Cells["E1"].Value = "Mes Anterior del Año en curso' 21 R";
            worksheetThird.Cells["F1"].Value = "m-o-m";
            worksheetThird.Cells["G1"].Value = "idProyecto";
            worksheetThird.Cells["H1"].Value = "Proyecto";
            //Content
            int i = 2;
            foreach (var summaryReturn in resultsSummaryReturns)
            {
                worksheetThird.Cells["A" + i.ToString()].Value = "Utilidad Neta";
                worksheetThird.Cells["B" + i.ToString()].Value = summaryReturn.UtilidadNetaActual;
                worksheetThird.Cells["C" + i.ToString()].Value = summaryReturn.UtilidadNetaLastYear;
                worksheetThird.Cells["D" + i.ToString()].Value = summaryReturn.YOYUtilidadNeta;
                worksheetThird.Cells["E" + i.ToString()].Value = summaryReturn.UtilidadNetaPreviousMonth;
                worksheetThird.Cells["F" + i.ToString()].Value = summaryReturn.MOMUtilidadNeta;
                worksheetThird.Cells["G" + i.ToString()].Value = summaryReturn.IdProyecto;
                worksheetThird.Cells["H" + i.ToString()].Value = summaryReturn.Proyecto;
                i++;
                worksheetThird.Cells["A" + i.ToString()].Value = "%EBITDA";
                worksheetThird.Cells["B" + i.ToString()].Value = summaryReturn.EBITDAPercentageActual;
                worksheetThird.Cells["C" + i.ToString()].Value = summaryReturn.EBITDAPercentageLastYear;
                // worksheetThird.Cells["D" + i.ToString()].Formula = $"=IF(C{i.ToString()},+B{i.ToString()}/C{i.ToString()}-1,0)"; // DON'T EXIST YOY PERCENTAGE
                worksheetThird.Cells["D" + i.ToString()].Value = ValidateValues(summaryReturn.EBITDAPercentageActual, summaryReturn.EBITDAPercentageLastYear) 
                    ? (summaryReturn.EBITDAPercentageActual/summaryReturn.EBITDAPercentageLastYear) - 1 : 0; // DON'T EXIST YOY PERCENTAGE
                worksheetThird.Cells["E" + i.ToString()].Value = summaryReturn.EBITDAPercentagePreviousMonth;
                worksheetThird.Cells["F" + i.ToString()].Value = summaryReturn.MOMEBITDA;
                worksheetThird.Cells["G" + i.ToString()].Value = summaryReturn.IdProyecto;
                worksheetThird.Cells["H" + i.ToString()].Value = summaryReturn.Proyecto;
                i++;
                worksheetThird.Cells["A" + i.ToString()].Value = "EBITDA";
                worksheetThird.Cells["B" + i.ToString()].Value = summaryReturn.EBITDAActual;
                worksheetThird.Cells["C" + i.ToString()].Value = summaryReturn.EBITDALastYear;
                worksheetThird.Cells["D" + i.ToString()].Value =
                    ValidateValues(summaryReturn.EBITDAActual, summaryReturn.EBITDALastYear)
                        ? (summaryReturn.EBITDAActual / summaryReturn.EBITDALastYear) - 1
                        : 0;
                worksheetThird.Cells["E" + i.ToString()].Value = summaryReturn.EBITDAPreviousMonth;
                worksheetThird.Cells["F" + i.ToString()].Value = summaryReturn.MOMEBITDA;
                worksheetThird.Cells["G" + i.ToString()].Value = summaryReturn.IdProyecto;
                worksheetThird.Cells["H" + i.ToString()].Value = summaryReturn.Proyecto;
                i++;
                worksheetThird.Cells["A" + i.ToString()].Value = "Utilidad Bruta";
                worksheetThird.Cells["B" + i.ToString()].Value = summaryReturn.UtilidadBrutaActual;
                worksheetThird.Cells["C" + i.ToString()].Value = summaryReturn.UtilidadBrutaLastYear;
                worksheetThird.Cells["D" + i.ToString()].Value =
                    ValidateValues(summaryReturn.UtilidadBrutaActual, summaryReturn.UtilidadBrutaLastYear)
                        ? (summaryReturn.UtilidadBrutaActual / summaryReturn.UtilidadBrutaLastYear) - 1
                        : 0;
                worksheetThird.Cells["E" + i.ToString()].Value = summaryReturn.UtilidadBrutaPreviousMonth;
                worksheetThird.Cells["F" + i.ToString()].Value =
                    ValidateValues(summaryReturn.UtilidadBrutaActual, summaryReturn.UtilidadBrutaPreviousMonth)
                        ? (summaryReturn.UtilidadBrutaActual / summaryReturn.UtilidadBrutaPreviousMonth) - 1
                        : 0;
                worksheetThird.Cells["G" + i.ToString()].Value = summaryReturn.IdProyecto;
                worksheetThird.Cells["H" + i.ToString()].Value = summaryReturn.Proyecto;
                i++;
                worksheetThird.Cells["A" + i.ToString()].Value = "Costo Ventas";
                worksheetThird.Cells["B" + i.ToString()].Value = summaryReturn.CostosActual;
                worksheetThird.Cells["C" + i.ToString()].Value = summaryReturn.CostosLastYear;
                worksheetThird.Cells["D" + i.ToString()].Value =
                    ValidateValues(summaryReturn.CostosActual, summaryReturn.CostosLastYear)
                        ? (summaryReturn.CostosActual / summaryReturn.CostosLastYear) - 1
                        : 0;
                worksheetThird.Cells["E" + i.ToString()].Value = summaryReturn.CostosPreviousMonth;
                worksheetThird.Cells["F" + i.ToString()].Value =
                    ValidateValues(summaryReturn.CostosActual, summaryReturn.CostosPreviousMonth)
                        ? (summaryReturn.CostosActual / summaryReturn.CostosPreviousMonth) - 1
                        : 0;
                worksheetThird.Cells["G" + i.ToString()].Value = summaryReturn.IdProyecto;
                worksheetThird.Cells["H" + i.ToString()].Value = summaryReturn.Proyecto;
                i++;
                worksheetThird.Cells["A" + i.ToString()].Value = "Ingresos";
                worksheetThird.Cells["B" + i.ToString()].Value = summaryReturn.IngresosActual;
                worksheetThird.Cells["C" + i.ToString()].Value = summaryReturn.IngresosLastYear;
                worksheetThird.Cells["D" + i.ToString()].Value =
                    ValidateValues(summaryReturn.IngresosActual, summaryReturn.IngresosLastYear)
                        ? (summaryReturn.IngresosActual / summaryReturn.IngresosLastYear) - 1
                        : 0;
                worksheetThird.Cells["E" + i.ToString()].Value = summaryReturn.IngresosPreviousMonth;
                worksheetThird.Cells["F" + i.ToString()].Value = summaryReturn.MOMIngresos;
                worksheetThird.Cells["G" + i.ToString()].Value = summaryReturn.IdProyecto;
                worksheetThird.Cells["H" + i.ToString()].Value = summaryReturn.Proyecto;
                i++;
                worksheetThird.Cells["A" + i.ToString()].Value = "Gastos";
                worksheetThird.Cells["B" + i.ToString()].Value = summaryReturn.GastosActual;
                worksheetThird.Cells["C" + i.ToString()].Value = summaryReturn.GastosLastYear;
                worksheetThird.Cells["D" + i.ToString()].Value =
                    ValidateValues(summaryReturn.GastosActual, summaryReturn.GastosLastYear)
                        ? (summaryReturn.GastosActual / summaryReturn.GastosLastYear) - 1
                        : 0;
                worksheetThird.Cells["E" + i.ToString()].Value = summaryReturn.GastosPreviousMonth;
                worksheetThird.Cells["F" + i.ToString()].Value =
                    ValidateValues(summaryReturn.GastosActual, summaryReturn.GastosPreviousMonth)
                        ? (summaryReturn.GastosActual / summaryReturn.GastosPreviousMonth) - 1
                        : 0;
                worksheetThird.Cells["G" + i.ToString()].Value = summaryReturn.IdProyecto;
                worksheetThird.Cells["H" + i.ToString()].Value = summaryReturn.Proyecto;
                i++;
                worksheetThird.Cells["A" + i.ToString()].Value = "Depreciacion";
                worksheetThird.Cells["B" + i.ToString()].Value = summaryReturn.DepreciacionActual;
                worksheetThird.Cells["C" + i.ToString()].Value = summaryReturn.DepreciacionLastYear;
                worksheetThird.Cells["D" + i.ToString()].Value =
                    ValidateValues(summaryReturn.DepreciacionActual, summaryReturn.DepreciacionLastYear)
                        ? (summaryReturn.DepreciacionActual / summaryReturn.DepreciacionLastYear) - 1
                        : 0;
                worksheetThird.Cells["E" + i.ToString()].Value = summaryReturn.DepreciacionPreviousMonth;
                worksheetThird.Cells["F" + i.ToString()].Value =
                    ValidateValues(summaryReturn.DepreciacionActual, summaryReturn.DepreciacionPreviousMonth)
                        ? (summaryReturn.DepreciacionActual / summaryReturn.DepreciacionPreviousMonth) - 1
                        : 0;
                worksheetThird.Cells["G" + i.ToString()].Value = summaryReturn.IdProyecto;
                worksheetThird.Cells["H" + i.ToString()].Value = summaryReturn.Proyecto;
                i++;
                worksheetThird.Cells["A" + i.ToString()].Value = "Interes";
                worksheetThird.Cells["B" + i.ToString()].Value = summaryReturn.InteresActual;
                worksheetThird.Cells["C" + i.ToString()].Value = summaryReturn.InteresLastYear;
                worksheetThird.Cells["D" + i.ToString()].Value =
                    ValidateValues(summaryReturn.InteresActual, summaryReturn.InteresLastYear)
                        ? (summaryReturn.InteresActual / summaryReturn.InteresLastYear) - 1
                        : 0;
                worksheetThird.Cells["E" + i.ToString()].Value = summaryReturn.InteresPreviousMonth;
                worksheetThird.Cells["F" + i.ToString()].Value =
                    ValidateValues(summaryReturn.InteresActual, summaryReturn.InteresPreviousMonth)
                        ? (summaryReturn.InteresActual / summaryReturn.InteresPreviousMonth) - 1
                        : 0;
                worksheetThird.Cells["G" + i.ToString()].Value = summaryReturn.IdProyecto;
                worksheetThird.Cells["H" + i.ToString()].Value = summaryReturn.Proyecto;
                i++;
                worksheetThird.Cells["A" + i.ToString()].Value = "%Utilidad Neta";
                worksheetThird.Cells["B" + i.ToString()].Value = summaryReturn.UtilidadNetaPercentageActual;
                worksheetThird.Cells["C" + i.ToString()].Value = summaryReturn.UtilidadNetaPercentageLastYear;
                worksheetThird.Cells["D" + i.ToString()].Value =
                    ValidateValues(summaryReturn.UtilidadNetaPercentageActual, summaryReturn.UtilidadNetaPercentageLastYear)
                        ? (summaryReturn.UtilidadNetaPercentageActual / summaryReturn.UtilidadNetaPercentageLastYear) - 1
                        : 0;
                worksheetThird.Cells["E" + i.ToString()].Value = summaryReturn.UtilidadNetaPercentagePreviousMonth;
                worksheetThird.Cells["F" + i.ToString()].Value =
                    ValidateValues(summaryReturn.UtilidadNetaPercentageActual, summaryReturn.UtilidadNetaPercentagePreviousMonth)
                        ? (summaryReturn.UtilidadNetaPercentageActual / summaryReturn.UtilidadNetaPercentagePreviousMonth) - 1
                        : 0;
                worksheetThird.Cells["G" + i.ToString()].Value = summaryReturn.IdProyecto;
                worksheetThird.Cells["H" + i.ToString()].Value = summaryReturn.Proyecto;
                i++;
            }

            worksheetThird.Cells["D:D"].Style.Numberformat.Format = "0.0000";
            worksheetThird.Cells["F:F"].Style.Numberformat.Format = "0.0000";

            worksheetThird.Cells["A1:H1"].AutoFilter = true;
            await excel.SaveAsync();
            return new ObjectResult(resultsSummaryReturns);
        }

        private static bool ValidateValues(decimal? a, decimal? b)
        {
            bool isSuccess = false;
            if (a.HasValue && b.HasValue)
            {
                if (b.Value != 0 && a.Value != 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            else
            {
                isSuccess = false;
            }

            return isSuccess;
        }

        public async Task<List<BudgetAdvance>> GetBudgetAdvance(string path)
        {
            var accounts = _context.CtbCuentas.Where(x => x.Cuenta.StartsWith("400") && x.Cuenta.Length > 10).Select(s=>s.IdCuenta).ToArray();
            var test = await (from a in _context.Proyectos
                where a.IdProyecto > 1189
                group a by new {a.IdProyecto, a.Proyecto1}
                into s
                select new BudgetAdvance
                {
                    IdProyecto = s.Key.IdProyecto,
                    Proyecto = s.Key.Proyecto1,
                    Ingresos = (from aaa in _context.CtbPolizas 
                        join bbb in _context.CtbPolizasDets on aaa.IdPoliza equals bbb.IdPoliza
                        where bbb.IdProyecto == s.Key.IdProyecto  && accounts.Contains(bbb.IdCuenta) && aaa.Cancelada.Equals(false)
                        select bbb.Abono).Sum(q=>q),
                    Costo = (from ccc in _context.AcPedidos
                        join bbb in _context.AcPedidosDets on ccc.IdPedido equals bbb.IdPedido 
                        where ccc.IdProyecto == s.Key.IdProyecto && ccc.Cancelado.Equals(false)
                        select bbb.Cantidad * bbb.Costo).Sum(q=>q)
                }).ToListAsync();
            return test;
        }

        public class FundingInvestmentOperation
        {
            public string Anio { get; set; }
            public string Mes { get; set; }
            // [Description("Capital social")]
            public decimal CapitalSocial { get; set; }
            // [Description("Fondeos de Banco")]
            public decimal FondeosBanco { get; set; }
            // [Description("Capital de trabajo")]
            public decimal CapitalTrabajo { get; set; }
            // [Description("Otras Inversiones")]
            public decimal OtrasInversiones { get; set; }
            public DateTime fecha { get; set; }
        }
        public class MainAccountEvaluation
        {
            [Description("anio")]
            public string Anio { get; set; }
            [Description("mes")]
            public string Mes { get; set; }
            // [Description("Capital social")]
            public decimal CuentasXcobrarCuenta123 { get; set; }
            // [Description("Fondeos de Banco")]
            public decimal AcredoresDiversos { get; set; }
            // [Description("Capital de trabajo")]
            public decimal CuentasXcobrar { get; set; }
            // [Description("Otras Inversiones")]
            public decimal CuentasXpagar { get; set; }
            public decimal Inventarios { get; set; }
            public decimal CreditosBancarios { get; set; }
        }
        public class EstadoResultado
        {
            public int? IdProyecto { get; set; }
            public string proyecto { get; set; }
            public decimal Costo { get; set; }
            public decimal Ingresos { get; set; }
            public decimal Gastos { get; set; }
            [Description("Utilidad Neta")]
            public decimal UtilidadNeta { get; set; }
            public int? mes { get; set; }
            public int? anio { get; set; }
        }
        public class BalanceSheetSummary
        {
            [Description("Activo Circulante")]
            public decimal ActivoCirculante { get; set; }
            [Description("Activo Fijo")]
            public decimal ActivoFijo { get; set; }
            [Description("Pasivo Corto Plazo")]
            public decimal PasivoCortoPlazo { get; set; }
            [Description("Pasivo Largo Plazo")]
            public decimal PasivoLargoPlazo { get; set; }
            [Description("Capital Social")]
            public decimal CapitalSocial { get; set; }
            [Description("mes")]
            public string Mes { get; set; }
            [Description("anio")]
            public string Anio { get; set; }
        }
    }
}

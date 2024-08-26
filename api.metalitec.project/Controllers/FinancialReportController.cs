using biz.erpmet.Repository.FinancialReport;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using api.metalitec.project.Models;
using api.metalitec.project.Models.ApiResponse;
using AutoMapper;
using biz.metalitec.Repository.ProductionWorkOrderContract;
using OfficeOpenXml;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.metalitec.project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancialReportController : ControllerBase
    {
        private readonly IFinancialReportRepository _financialReportRepository;
        private readonly IProductionWorkOrderContractRepository _productionWorkOrderContractRepository;
        private readonly IMapper _mapper;
        public FinancialReportController(IFinancialReportRepository financialReportRepository, IMapper mapper, IProductionWorkOrderContractRepository productionWorkOrderContractRepository)
        {
            _mapper = mapper;
            _financialReportRepository = financialReportRepository;
            _productionWorkOrderContractRepository = productionWorkOrderContractRepository;
        }
        
        // GET: api/<FinancialReportController>
        /// <summary>
        /// Avance presupuestal actual
        /// </summary>
        /// <returns>A new Action Result and edit excel file</returns>
        [HttpGet]
        [Route("Budget-Advance", Name = "BudgetAdvance")]
        public async Task<ActionResult<ApiResponse<List<BudgetAdvanceDto>>>> GetBudgetAdvance()
        {
            ApiResponse<List<BudgetAdvanceDto>> response = new ApiResponse<List<BudgetAdvanceDto>>();
            try
            {
                string excelFile = Path.GetFullPath("Files/002-Avance_presupuestal_actual.xlsx");
                var data = await _productionWorkOrderContractRepository.GetAdvanceBudget();
                var anotherData =
                    _mapper.Map<List<BudgetAdvanceDto>>(await _financialReportRepository.GetBudgetAdvance(excelFile));
                foreach (var advanceDto in anotherData)
                {
                    advanceDto.Total = data.Any(f => f.Name.Contains(advanceDto.Proyecto)) 
                        ? data.FirstOrDefault(f => f.Name.Contains(advanceDto.Proyecto)).Total
                        : 0;
                }
                FileInfo fileInfo = new FileInfo(excelFile);
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
                worksheet.Cells["A1"].LoadFromCollection(anotherData,true);
                await excel.SaveAsync();
                response.Result = anotherData;
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                response.Success = false;
                return StatusCode(500, response);
            }

            return StatusCode(201, response);
        }
        
        // GET: api/<FinancialReportController>
        /// <summary>
        /// Resumen Resultados Operativos
        /// </summary>
        /// <returns>A new Action Result and edit excel file</returns>
        [HttpGet]
        [Route("Operating-Results-Summary", Name = "OperatingResultsSummary")]
        public async Task<ActionResult<ApiResponse<ActionResult>>> GetOperatingResultsSummary()
        {
            ApiResponse<ActionResult> response = new ApiResponse<ActionResult>();
            try
            {
                string excelFile = Path.GetFullPath("Files/002-Resumen Resultados Operativos.xlsx");
                response.Message = "Response Success";
                response.Success = true;
                response.Result = await _financialReportRepository.GetOperatingResultsSummary(excelFile);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                response.Success = false;
                return StatusCode(500, response);
            }

            return StatusCode(201, response);
        }
        
        // GET: api/<FinancialReportController>
        /// <summary>
        /// Flujo de efectivo
        /// </summary>
        /// <returns>A new Action Result and edit excel file</returns>
        [HttpGet]
        [Route("Cash-Flow", Name = "CashFlow")]
        public async Task<ActionResult> GetCashFlow()
        {
            try
            {
                string excelFile = Path.GetFullPath("Files/002-FlujoEfectivo.xlsx");
                return await _financialReportRepository.GetCashFlow(excelFile);
            }
            catch (Exception e)
            {
                return StatusCode(500, new {Status = false, Message = e.Message, Result = e.ToString()});
            }
            
        }
        
        // GET: api/<FinancialReportController>
        /// <summary>
        /// Estado de resultados
        /// </summary>
        /// <returns>A new Action Result and edit excel file</returns>
        [HttpGet]
        [Route("State-Results", Name = "StateResults")]
        public async Task<ActionResult> Get()
        {
            try
            {
                string excelFile = Path.GetFullPath("Files/002-EstadoResultados.xlsx");
                return await _financialReportRepository.GetStateResult(excelFile);
            }
            catch (Exception e)
            {
                return StatusCode(500, new {Status = false, Message = e.Message, Result = e.ToString()});
            }
            
        }
        /// <summary>
        /// Evaluación de cuentas principales capital de trabajo
        /// </summary>
        /// <returns>A new Action Result and edit excel file</returns>
        [HttpGet]
        [Route("Main-Account-Evaluation", Name = "MainAccountEvaluation")]
        public async Task<ActionResult> GetMainAccountEvaluation()
        {
            string excelFile = Path.GetFullPath("Files/002-EvolucionCuentasPrincipalesCT.xlsx");
            return await _financialReportRepository.GetMainAccountEvaluation(excelFile);
        }
        /// <summary>
        /// Resumen balance general
        /// </summary>
        /// <returns>A new Action Result and edit excel file</returns>
        [HttpGet]
        [Route("Balance-Sheet-Summary", Name = "BalanceSheetSummary")]
        public async Task<ActionResult> GetBalanceSheetSummary()
        {
            string excelFile = Path.GetFullPath("Files/002-ResumenBalanceGeneral.xlsx");
            return await _financialReportRepository.GetBalanceSheetSummary(excelFile);
        }
        /// <summary>
        /// Fondeo de operaciones inversiones
        /// </summary>
        /// <returns>A new Action Result and edit excel file</returns>
        [HttpGet]
        [Route("Funding-Investment-Operations", Name = "FundingInvestmentOperations")]
        public async Task<ActionResult> GetFundingInvestmentOperations()
        {
            string excelFile = Path.GetFullPath("Files/002-FondeoOperacionesInversiones.xlsx");
            return await _financialReportRepository.GetFundingInvestmentOperations(excelFile);
        }
    }
}

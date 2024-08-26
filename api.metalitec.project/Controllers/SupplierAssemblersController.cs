using System;
using System.IO;
using System.Threading.Tasks;
using api.metalitec.project.Models.ApiResponse;
using biz.erpmet.Repository.SupplierAssemblers;
using biz.metalitec.Repository.ProductionWorkOrderContract;
using Microsoft.AspNetCore.Mvc;

namespace api.metalitec.project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierAssemblersController : ControllerBase
    {
        private readonly IProductionWorkOrderContractRepository _productionWorkOrderContractRepository;
        private readonly ISupplierAssemblersRepository _supplierAssemblersRepository;

        public SupplierAssemblersController(
            IProductionWorkOrderContractRepository productionWorkOrderContractRepository,
            ISupplierAssemblersRepository supplierAssemblersRepository)
        {
            _productionWorkOrderContractRepository = productionWorkOrderContractRepository;
            _supplierAssemblersRepository = supplierAssemblersRepository;
        }
        
        // GET: api/<SupplierAssemblersController>
        /// <summary>
        /// Montaje liberado en obra
        /// </summary>
        /// <returns>A new Action Result and edit excel file</returns>
        [HttpGet]
        [Route("Assembly-Released-On-Site", Name = "AssemblyReleasedOnSite")]
        public async Task<ActionResult<ApiResponse<ActionResult>>> GetAssemblyReleasedOnSite()
        {
            ApiResponse<ActionResult> response = new ApiResponse<ActionResult>();
            try
            {
                string excelFile = Path.GetFullPath("Files/005-Montaje liberado en obra.xlsx");
                response.Message = "Success";
                response.Result = await _productionWorkOrderContractRepository.GetAssemblyReleasedOnSite(excelFile);
            }
            catch (Exception e)
            {
                response.Message = $"{e.Message}";
                response.Success = false;
                return StatusCode(500, response);
            }

            return StatusCode(201, response);
        }
        
        // GET: api/<SupplierAssemblersController>
        /// <summary>
        /// TOP 5 Proveedores montadores
        /// </summary>
        /// <returns>A new Action Result and edit excel file</returns>
        [HttpGet]
        [Route("Program-Mounting", Name = "ProgramMounting")]
        public async Task<ActionResult<ApiResponse<ActionResult>>> GetProgramMounting()
        {
            ApiResponse<ActionResult> response = new ApiResponse<ActionResult>();
            try
            {
                string excelFile = Path.GetFullPath("Files/005-Montaje Programa.xlsx");
                response.Message = "Success";
                response.Result = await _productionWorkOrderContractRepository.GetSupplierAssemblers(excelFile);
            }
            catch (Exception e)
            {
                response.Message = $"{e.Message}";
                response.Success = false;
                return StatusCode(500, response);
            }

            return StatusCode(201, response);
        }
        
        // GET: api/<SupplierAssemblersController>
        /// <summary>
        /// Top 5 Proveedores Montadores
        /// </summary>
        /// <returns>A new Action Result and edit excel file</returns>
        [HttpGet]
        [Route("Top-5", Name = "Top-5")]
        public async Task<ActionResult<ApiResponse<ActionResult>>> GetTop()
        {
            ApiResponse<ActionResult> response = new ApiResponse<ActionResult>();
            try
            {
                string excelFile = Path.GetFullPath("Files/005-Top.xlsx");
                response.Message = "Success";
                response.Result = await _supplierAssemblersRepository.GetTop(excelFile);
            }
            catch (Exception e)
            {
                response.Message = $"{e.Message}";
                response.Success = false;
                return StatusCode(500, response);
            }

            return StatusCode(201, response);
        }
        
        // GET: api/<SupplierAssemblersController>
        /// <summary>
        /// Variación Presupuesto
        /// </summary>
        /// <returns>A new Action Result and edit excel file</returns>
        [HttpGet]
        [Route("Variation-Budget", Name = "VariationBudget")]
        public async Task<ActionResult<ApiResponse<ActionResult>>> GetVariationBudget()
        {
            ApiResponse<ActionResult> response = new ApiResponse<ActionResult>();
            try
            {
                string excelFile = Path.GetFullPath("Files/005-Variación Presupuesto.xlsx");
                response.Message = "Success";
                response.Result = await _supplierAssemblersRepository.GetVariationBudget(excelFile);
            }
            catch (Exception e)
            {
                response.Message = $"{e.Message}";
                response.Success = false;
                return StatusCode(500, response);
            }

            return StatusCode(201, response);
        }
        
        // GET: api/<SupplierAssemblersController>
        /// <summary>
        /// Pagos Montaje
        /// </summary>
        /// <returns>A new Action Result and edit excel file</returns>
        [HttpGet]
        [Route("Payments-Assembly", Name = "PaymentsAssembly")]
        public async Task<ActionResult<ApiResponse<ActionResult>>> GetPaymentsAssembly()
        {
            ApiResponse<ActionResult> response = new ApiResponse<ActionResult>();
            try
            {
                string excelFile = Path.GetFullPath("Files/005-Pagos  Montaje.xlsx");
                response.Message = "Success";
                response.Result = await _supplierAssemblersRepository.GetPaymentsAssembly(excelFile);
            }
            catch (Exception e)
            {
                response.Message = $"{e.Message}";
                response.Success = false;
                return StatusCode(500, response);
            }

            return StatusCode(201, response);
        }
    }
}
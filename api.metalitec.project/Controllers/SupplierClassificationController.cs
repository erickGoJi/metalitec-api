using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using api.metalitec.project.Models.ApiResponse;
using biz.erpmet.Model;
using biz.erpmet.Repository.SupplierClassification;
using Microsoft.AspNetCore.Mvc;

namespace api.metalitec.project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierClassificationController : ControllerBase
    {
        private readonly ISupplierClassificationRepository _supplierClassificationRepository;

        public SupplierClassificationController(ISupplierClassificationRepository supplierClassificationRepository)
        {
            _supplierClassificationRepository = supplierClassificationRepository;
        }

        // GET: api/<SupplierClassificationController>
        /// <summary>
        /// TOP de Proveedores con mas compras
        /// </summary>
        /// <returns>A new Action Result and edit excel file</returns>
        [HttpGet]
        [Route("Top", Name = "Top")]
        public async Task<ActionResult<ApiResponse<ActionResult>>> Get()
        {
            ApiResponse<ActionResult> response = new ApiResponse<ActionResult>();
            try
            {
                string excelFile = Path.GetFullPath("Files/004-Top5.xlsx");
                response.Message = "Success";
                response.Result = await _supplierClassificationRepository.GetTopSuppliers(excelFile);
            }
            catch (Exception e)
            {
                response.Message = $"{e.Message}";
                response.Success = false;
                return StatusCode(500, response);
            }
            return StatusCode(201, response);
        }

        // GET: api/<SupplierClassificationController>
        /// <summary>
        /// Famila de Materiales
        /// </summary>
        /// <returns>A new Action Result and edit excel file</returns>
        [HttpGet]
        [Route("Materials-Family", Name = "MaterialsFamily")]
        public async Task<ActionResult<ApiResponse<ActionResult>>> GetMaterialsFamily()
        {
            ApiResponse<ActionResult> response = new ApiResponse<ActionResult>();
            try
            {
                string excelFile = Path.GetFullPath("Files/004-Familia de Materiales.xlsx");
                response.Message = "Success";
                response.Result = await _supplierClassificationRepository.GetMaterialsFamily(excelFile);
            }
            catch (Exception e)
            {
                response.Message = $"{e.Message}";
                response.Success = false;
                return StatusCode(500, response);
            }
            return StatusCode(201, response);
        }

        // GET: api/<SupplierClassificationController>
        /// <summary>
        /// Historial de compras
        /// </summary>
        /// <returns>A new Action Result and edit excel file</returns>
        [HttpGet]
        [Route("Purchase-History", Name = "PurchaseHistory")]
        public async Task<ActionResult<ApiResponse<ActionResult>>> GetPurchaseHistory()
        {
            ApiResponse<ActionResult> response = new ApiResponse<ActionResult>();
            try
            {
                string excelFile = Path.GetFullPath("Files/004-Historial de compras.xlsx");
                
                // return Ok();
                response.Message = "Success";
                response.Result = await _supplierClassificationRepository.GetPurchaseHistory(excelFile);
            }
            catch (Exception e)
            {
                response.Message = $"{e.Message}";
                response.Success = false;
                return StatusCode(500, response);
            }
            return StatusCode(201, response);
        }

        // GET: api/<SupplierClassificationController>
        /// <summary>
        /// Precio Tendencia
        /// </summary>
        /// <returns>A new Action Result and edit excel file</returns>
        [HttpGet]
        [Route("Price-Trend", Name = "PriceTrend")]
        public async Task<ActionResult<ApiResponse<ActionResult>>> GetPriceTrend()
        {
            ApiResponse<ActionResult> response = new ApiResponse<ActionResult>();
            try
            {
                string excelFile = Path.GetFullPath("Files/004-Precio Tendencia.xlsx");
                
                // return Ok();
                response.Message = "Success";
                response.Result = await _supplierClassificationRepository.GetPriceTrend(excelFile);
            }
            catch (Exception e)
            {
                response.Message = $"{e.Message}";
                response.Success = false;
                return StatusCode(500, response);
            }
            return StatusCode(201, response);

        }
        
        // GET: api/<SupplierClassificationController>
        /// <summary>
        /// Proyectos
        /// Lista de proyectos totales
        /// </summary>
        /// <returns>A new list of projects and edit excel file</returns>
        [HttpGet]
        [Route("Projects", Name = "Projects")]
        public async Task<ActionResult<ApiResponse<List<Proyecto>>>> GetProjects()
        {
            ApiResponse<List<Proyecto>> response = new ApiResponse<List<Proyecto>>();
            try
            {
                string excelFile = Path.GetFullPath("Files/004-Proyectos.xlsx");
                var Projects= await _supplierClassificationRepository.GetProjectsList(excelFile);
                response.Message = "Success";
                response.Success = true;
                response.Result = Projects;
            }
            catch (Exception e)
            {
                response.Message = $"{e.Message}";
                response.Success = true;
                return StatusCode(500, response);
            }

            return StatusCode(201, response);
        }
        
        // GET: api/<SupplierClassificationController>
        /// <summary>
        /// Total Proveedores
        /// </summary>
        /// <returns>A new integer and edit excel file</returns>
        [HttpGet]
        [Route("Suppliers", Name = "Suppliers")]
        public async Task<ActionResult<ApiResponse<int>>> GetSupplierList()
        {
            ApiResponse<int> response = new ApiResponse<int>();
            try
            {
                string excelFile = Path.GetFullPath("Files/004-Total Proveedores.xlsx");
                var result = await _supplierClassificationRepository.GetSupplierCount(excelFile);
                response.Message = "Success";
                response.Result = result;
                response.Success = true;
            }
            catch (Exception e)
            {
                response.Message = $"{e.Message}";
                response.Success = true;
                return StatusCode(500, response);
            }

            return StatusCode(201, response);
        }

    }
}
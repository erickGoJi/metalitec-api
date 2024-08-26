using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using api.metalitec.project.ActionFilter;
using api.metalitec.project.Models;
using api.metalitec.project.Models.ApiResponse;
using api.metalitec.project.Services.Logger;
using biz.admin.Repository.File;
using biz.admin.Repository.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NPOI.SS.Formula.Functions;
using OfficeOpenXml;
using Org.BouncyCastle.Math.EC;
using MediaTypeHeaderValue = Microsoft.Net.Http.Headers.MediaTypeHeaderValue;

namespace api.metalitec.project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly ILoggerManager _loggerManager;
        private readonly IFileRepository _fileRepository;
        private readonly IUtilityRepository _utilityRepository;

        public FileController(ILoggerManager loggerManager, IFileRepository fileRepository, IUtilityRepository utilityRepository)
        {
            _loggerManager = loggerManager;
            _fileRepository = fileRepository;
            _utilityRepository = utilityRepository;
        }

        /// <summary>
        /// Subir archivo de excel 
        /// </summary>
        /// <param name="file">Archivo</param>
        /// <returns>Excel Updated</returns>
        /// <response code="200">Retorna un valor booleano en verdadero</response>
        /// <response code="400">Si el archivo no cumple los requerimientos para sustituir el ya existente </response>
        [HttpPost, DisableRequestSizeLimit]
        [ServiceFilterAttribute(typeof(ValidationFilterAttribute))]
        public async Task<ActionResult<ApiResponse<bool>>> ExcelUpload(IFormFile file)
        {
            ApiResponse<bool> response = new ApiResponse<bool>();
            try
            {
                string[] fileNames = new[] { "002-Avance_presupuestal_contratado.xlsx", "TEMPLATE PROGRAMADO VS REAL STRUMIS.xlsx" };
                if (file == null || file.Length <= 0)
                {
                    response.Result = false;
                    response.Success = false;
                    response.Message = "File is Empty";
                    return BadRequest(response);
                }
                
                if (!Path.GetExtension(file.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
                {
                    response.Result = false;
                    response.Success = false;
                    response.Message = "File extension is not supported";
                    return BadRequest(response);
                }
                
                if (!fileNames.Contains(file.FileName))
                {
                    response.Result = false;
                    response.Success = false;
                    response.Message = "File Name is not supported";
                    return BadRequest(response);
                }

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                await using var stream = new MemoryStream();
                await file.CopyToAsync(stream);
                using var package = new ExcelPackage(stream);
                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
                
                int rows = worksheet.Dimension.Rows; // Number of Rows
                int columns = worksheet.Dimension.Columns; // Number of Columns
                switch (file.FileName)
                {
                    case ("002-Avance_presupuestal_contratado.xlsx"):
                        if (columns == 5)
                        {
                            var columnIDProject = worksheet.Cells["1:5"].Any(c => c.Value.ToString() == "idproyecto");
                            var columnProject = worksheet.Cells["1:5"].Any(c => c.Value.ToString() == "proyecto");
                            var columnIngresos = worksheet.Cells["1:5"].Any(c => c.Value.ToString() == "ingresos");
                            var columnCosto = worksheet.Cells["1:5"].Any(c => c.Value.ToString() == "COSTO");
                            var columnPesoProyecto = worksheet.Cells["1:5"].Any(c => c.Value.ToString() == "PESO PROYECTO");
                            if (columnCosto && columnProject && columnIDProject && columnIngresos && columnPesoProyecto)
                            {
                                var startRow = 1;
                                var endRow = worksheet.Dimension.Rows;
                                var columnStart = 1;
                                var columnEnd = worksheet.Cells.End.Column;

                                var cellRange = worksheet.Cells[startRow, columnStart , endRow, columnEnd];

                                var isRowEmpty = cellRange.All(c => c.Value == null);
                                if (isRowEmpty)
                                {
                                    response.Result = false;
                                    response.Success = false;
                                    response.Message = "Row is empty in Excel";
                                    return BadRequest(response);
                                }

                                bool isValid = _fileRepository.ValidateRows(worksheet, rows, columns);
                                if (isValid.Equals(false))
                                {
                                    response.Result = false;
                                    response.Message = "File format is incorrect.";
                                }
                                string excelFile = "Files/002-Avance_presupuestal_contratado.xlsx";
                                await _utilityRepository.DeleteFile(excelFile);
                                await _utilityRepository.UploadFile(file);
                                response.Success = true;
                                response.Message = "File uploaded successfully";
                            }
                            else
                            {
                                response.Result = false;
                                response.Success = false;
                                response.Message = "Name of columns are incorrect in Excel";
                                return BadRequest(response);
                            }
                        }
                        else
                        {
                            response.Result = false;
                            response.Success = false;
                            response.Message = "Number of columns are incorrect in Excel";
                            return BadRequest(response);
                        }
                        break;
                    case ("TEMPLATE PROGRAMADO VS REAL STRUMIS.xlsx"):
                        if (columns == 24)
                        {
                            var columnA = worksheet.Cells["A1:A1"].Any(c => c.Value.ToString() == "Instalación");
                            var columnB = worksheet.Cells["B1:B1"].Any(c => c.Value.ToString() == "Nombre");
                            var columnC = worksheet.Cells["C1:C1"].Any(c => c.Value.ToString() == "Fase");
                            var columnD = worksheet.Cells["D1:D1"].Any(c => c.Value.ToString() == "Descripción");
                            var columnE = worksheet.Cells["E1:E1"].Any(c => c.Value.ToString() == "Ubicación");
                            var columnF = worksheet.Cells["F1:F1"].Any(c => c.Value.ToString() == "Cambio");
                            var columnG = worksheet.Cells["G1:G1"].Any(c => c.Value.ToString() == "Tarea");
                            var columnH = worksheet.Cells["H1:H1"].Any(c => c.Value.ToString() == "Total Weight (kg)");
                            var columnI = worksheet.Cells["I1:I1"].Any(c => c.Value.ToString() == "Total Time (Horas)");
                            var columnJ = worksheet.Cells["J1:J1"].Any(c => c.Value.ToString() == "Hrs /  (kg)");
                            var columnK = worksheet.Cells["K1:K1"].Any(c => c.Value.ToString() == "Allocated Weight (kg)");
                            var columnL = worksheet.Cells["L1:L1"].Any(c => c.Value.ToString() == "Allocated Time (Horas)");
                            var columnM = worksheet.Cells["M1:N1"].Any(c => c.Value.ToString() == "Weight (kg)");
                            var columnN = worksheet.Cells["N1:N1"].Any(c => c.Value.ToString() == "Time (Horas)");
                            var columnO = worksheet.Cells["O1:O1"].Any(c => c.Value.ToString() == "Weight (kg)");
                            var columnP = worksheet.Cells["P1:P1"].Any(c => c.Value.ToString() == "Time (Horas)");
                            var columnQ = worksheet.Cells["Q1:Q1"].Any(c => c.Value.ToString() == "Weight (kg)");
                            var columnR = worksheet.Cells["R1:R1"].Any(c => c.Value.ToString() == "Time (Horas)");
                            var columnS = worksheet.Cells["S1:S1"].Any(c => c.Value.ToString() == "Weight (kg)");
                            var columnT = worksheet.Cells["T1:T1"].Any(c => c.Value.ToString() == "Time (Horas)");
                            var columnU = worksheet.Cells["U1:U1"].Any(c => c.Value.ToString() == "Weight (kg)");
                            var columnV = worksheet.Cells["V1:V1"].Any(c => c.Value.ToString() == "Time (Horas)");
                            var columnW = worksheet.Cells["W1:W1"].Any(c => c.Value.ToString() == "Weight (kg)");
                            var columnX = worksheet.Cells["X1:X1"].Any(c => c.Value.ToString() == "Time (Horas)");
                            if (columnA && columnB && columnC && columnD && columnE && columnF && columnG && columnH && columnI && columnJ && columnK && columnL && 
                                columnM && columnN && columnO && columnP && columnQ && columnR && columnS && columnT && columnU && columnV && columnW && columnX)
                            {
                                var startRow = 1;
                                var endRow = worksheet.Dimension.Rows;
                                var columnStart = 1;
                                var columnEnd = worksheet.Cells.End.Column;

                                var cellRange = worksheet.Cells[startRow, columnStart , endRow, columnEnd];

                                var isRowEmpty = cellRange.All(c => c.Value == null);
                                if (isRowEmpty)
                                {
                                    response.Result = false;
                                    response.Success = false;
                                    response.Message = "Row is empty in Excel";
                                    return BadRequest(response);
                                }

                                bool isValid = _fileRepository.ValidateRowsRealStrumis(worksheet, rows, columns);
                                if (isValid.Equals(false))
                                {
                                    response.Result = false;
                                    response.Message = "File format is incorrect.";
                                    return BadRequest(response);
                                }
                                string excelFile = "Files/TEMPLATE PROGRAMADO VS REAL STRUMIS.xlsx";
                                await _utilityRepository.DeleteFile(excelFile);
                                await _utilityRepository.UploadFile(file);
                                response.Success = true;
                                response.Message = "File uploaded successfully";
                            }
                            else
                            {
                                response.Result = false;
                                response.Success = false;
                                response.Message = "Name of columns are incorrect in Excel";
                                return BadRequest(response);
                            }
                        }
                        else
                        {
                            response.Result = false;
                            response.Success = false;
                            response.Message = "Number of columns are incorrect in Excel";
                            return BadRequest(response);
                        }
                        break;
                    default:
                        response.Result = false;
                        response.Success = false;
                        response.Message = "File Name is not supported";
                        break;
                }

            }
            catch (Exception ex)
            {
                response.Result = false;
                response.Success = false;
                response.Message = $"Something went wrong: { ex.Message }";
                _loggerManager.LogError($"Something went wrong: { ex.ToString() }");
                return StatusCode(500, response);
            }

            return StatusCode(201, response);
        }

        /// <summary>
        /// Lista de archivos Excel que se pueden dar de alta
        /// </summary>
        /// <returns>lista de nombres de archivos Excel</returns>
        [HttpGet]
        [Route("All-Files", Name = "AllFiles")]
        public async Task<ActionResult<ApiResponse<List<CatFile>>>> GetAllFiles()
        {
            ApiResponse<List<CatFile>> response = new ApiResponse<List<CatFile>>();
            try
            {
                List<CatFile> files = new List<CatFile>();
                files.Add(new CatFile()
                {
                    File = "002-Avance_presupuestal_contratado.xlsx",
                    Id = 1
                });
                files.Add(new CatFile()
                {
                    File = "TEMPLATE PROGRAMADO VS REAL STRUMIS.xlsx",
                    Id = 2
                });
                response.Message = "Operation was successfully";
                response.Result = files;
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Result = null;
                response.Success = false;
                response.Message = $"Something went wrong: { ex.Message }";
                _loggerManager.LogError($"Something went wrong: { ex.ToString() }");
                return StatusCode(500, response);
            }

            return StatusCode(201, response);
        }

    }
}
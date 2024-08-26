using System;
using System.Collections.Generic;
using System.IO;
using biz.admin.Repository.File;
using dal.admin.DBContext;
using dal.admin.Repository.Generic;
using OfficeOpenXml;

namespace dal.admin.Repository.File
{
    public class FileRepository : GenericRepository<biz.admin.Models.User>, IFileRepository
    {
        public FileRepository(MetalitecDataContext context) : base(context)
        {
            
        }
        
        public bool ValidateRows(ExcelWorksheet worksheet, int totalRows, int totalCols)
        {
            bool result = true;
            for (int i = 2; i <= totalRows; i++) //data rows start from 2`
            {
                for (int j = 1; j <= totalCols; j++)
                {
                    var cell= worksheet.Cells[i, j];

                    switch (j)
                    {
                        // ID PROYECTO
                        case 1:
                            {
                                result&= ValidateNumber(cell, "idproyecto");
                                break;
                            }
                        // PROYECTO
                        case 2:
                            {
                                result&= ValidateText(cell, "proyecto");
                                break;
                            }
                        // INGRESOS
                        case 3:
                            {
                                result&= ValidateNumber(cell, "ingresos");
                                break;
                            }
                        // COSTO
                        case 4:
                            {
                                result&= ValidateNumber(cell, "COSTO");
                                break;
                            }
                        // PESO PROYECTO
                        case 5:
                            {
                                result&= ValidateNumber(cell, "PESO PROYECTO");
                                break;
                            }
                    }                   
                }
            }

            return result;
        }

        public bool ValidateRowsRealStrumis(ExcelWorksheet worksheet, int totalRows, int totalCols)
        {
            bool result = true;
            for (int i = 2; i <= totalRows; i++) //data rows start from 2`
            {
                for (int j = 1; j <= totalCols; j++)
                {
                    var cell= worksheet.Cells[i, j];

                    switch (j)
                    {
                        // Instalación
                        case 1:
                        {
                            result&= ValidateText(cell, "Instalación");
                            break;
                        }
                        // Nombre
                        case 2:
                        {
                            result&= ValidateText(cell, "Nombre");
                            break;
                        }
                        // Fase
                        case 3:
                        {
                            result&= ValidateText(cell, "Fase");
                            break;
                        }
                        // Descripción
                        case 4:
                        {
                            result&= ValidateText(cell, "Descripción");
                            break;
                        }
                        // Ubicación
                        case 5:
                        {
                            result&= ValidateText(cell, "Ubicación");
                            break;
                        }
                        // Cambio
                        case 6:
                        {
                            result&= ValidateText(cell, "Cambio");
                            break;
                        }
                        // Tarea
                        case 7:
                        {
                            result&= ValidateText(cell, "Tarea");
                            break;
                        }
                        // Total Weight (kg)
                        case 8:
                        {
                            result&= ValidateNumber(cell, "Total Weight (kg)");
                            break;
                        }
                        // Total Time (Horas)
                        case 9:
                        {
                            result&= ValidateNumber(cell, "Total Time (Horas)");
                            break;
                        }
                        // Hrs /  (kg)
                        case 10:
                        {
                            result&= ValidateNumber(cell, "Hrs /  (kg)");
                            break;
                        }
                        // Allocated Weight (kg)
                        case 11:
                        {
                            result&= ValidateNumber(cell, "Allocated Weight (kg)");
                            break;
                        }
                        // Allocated Time (Horas)
                        case 12:
                        {
                            result&= ValidateNumber(cell, "Allocated Time (Horas)");
                            break;
                        }
                        // Weight (kg)
                        case 13:
                        {
                            result&= ValidateNumber(cell, "Weight (kg)");
                            break;
                        }
                        // Time (Horas)
                        case 14:
                        {
                            result&= ValidateNumber(cell, "Time (Horas)");
                            break;
                        }
                        // Weight (kg)
                        case 15:
                        {
                            result&= ValidateNumber(cell, "Weight (kg)");
                            break;
                        }
                        // Time (Horas)
                        case 16:
                        {
                            result&= ValidateNumber(cell, "Time (Horas)");
                            break;
                        }
                        // Weight (kg)
                        case 17:
                        {
                            result&= ValidateNumber(cell, "Weight (kg)");
                            break;
                        }
                        // Time (Horas)
                        case 18:
                        {
                            result&= ValidateNumber(cell, "Time (Horas)");
                            break;
                        }
                        // Weight (kg)
                        case 19:
                        {
                            result&= ValidateNumber(cell, "Weight (kg)");
                            break;
                        }
                        // Time (Horas)
                        case 20:
                        {
                            result&= ValidateNumber(cell, "Time (Horas)");
                            break;
                        }
                        case 21:
                        {
                            result&= ValidateNumber(cell, "Weight (kg)");
                            break;
                        }
                        // Time (Horas)
                        case 22:
                        {
                            result&= ValidateNumber(cell, "Time (Horas)");
                            break;
                        }
                        // Weight (kg)
                        case 23:
                        {
                            result&= ValidateNumber(cell, "Weight (kg)");
                            break;
                        }
                        // Time (Horas)
                        case 24:
                        {
                            result&= ValidateNumber(cell, "Time (Horas)");
                            break;
                        }
                    }                   
                }
            }

            return result;
        }

        //
        // private bool ValidateEmailAddress(ExcelRange cell, string columnName) { 
        //     bool result = true;
        //     result = ValidateText(cell, columnName); //validate if empty or not
        //
        //     if (result)
        //     {
        //         if (!ValidateEmail(cell.Value.ToString())) //ValidateEmail => true, if email format is correct
        //         {
        //             result = SetError(cell, "Email address format is invalid.");
        //         }
        //         else if (cell.Value.ToString().Length > 150)
        //         {
        //             result = SetError(cell, "Email address too long. Max characters 150.");
        //         }
        //     }
        //     return result;
        // }

        private bool ValidateText(ExcelRange cell, string columnName)
        {
            bool result = true;
            string error = string.Format("{0} is empty", columnName);

            if (cell.Value != null)
            {
                //check if cell value has a value
                if (string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    result = SetError(cell, error);
                }
            }
            else
            {
                result = SetError(cell, error);
            }

            return result;
        }


        private bool ValidateNumber(ExcelRange cell, string columnName)
        {
            bool result = true;
            double value = 0.0;
            string error = string.Format("{0} format is incorrect.", columnName);
            result = ValidateText(cell, columnName);
            if (result)
            {
                if (!double.TryParse(cell.Value.ToString(), out value))
                {
                    result = SetError(cell, error);
                }
            }
            return result;
        }

        private bool ValidateDate(ExcelRange cell, string columnName)
        {
            bool result = true;
            DateTime date = DateTime.MinValue;
            string error = string.Format("{0} format is incorrect.", columnName);
            result = ValidateText(cell, columnName);

            if (result)
            {
                if (!DateTime.TryParse(cell.Value.ToString(), out date))
                {
                    result = SetError(cell, error);
                }
            }

            return result;
        }
        
        private bool SetError(ExcelRange cell, string errorComment)
        {           
            // var fill = cell.Style.Fill;
            // fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
            // fill.BackgroundColor.SetColor(System.Drawing.Color.Red);
            // cell.AddComment(errorComment, "");

            return false;
        }
    }
}
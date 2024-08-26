using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportQsanalysis
    {
        public int QsanalysisId { get; set; }
        public string QsAnalysis { get; set; }
        public int ContractId { get; set; }
        public string Contract { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public double CostValue { get; set; }
        public double SellValue { get; set; }
        public string QsAnalysisNotes { get; set; }
    }
}

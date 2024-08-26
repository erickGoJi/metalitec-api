using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportEmployeeproductionworkorderhistory
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string ProductionWorkOrder { get; set; }
        public string ProductionProcess { get; set; }
        public string WorkStation { get; set; }
        public string ItemLocation { get; set; }
        public double Quantity { get; set; }
        public double? UnitWeight { get; set; }
        public double? UnitArea { get; set; }
        public double? Weight { get; set; }
        public double? Area { get; set; }
        public string Mark { get; set; }
        public string MarkItem { get; set; }
        public DateTime MovedOn { get; set; }
    }
}

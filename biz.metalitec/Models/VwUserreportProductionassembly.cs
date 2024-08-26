using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportProductionassembly
    {
        public int ProductionAssemblyId { get; set; }
        public string ProductionAssembly { get; set; }
        public string ProductionAssemblyDescription { get; set; }
        public DateTime ProductionAssemblyDate { get; set; }
        public byte Complete { get; set; }
        public int? ContractId { get; set; }
        public string Contract { get; set; }
        public int? EmployeeId { get; set; }
        public string Employee { get; set; }
        public string ProductionAssemblyNotes { get; set; }
    }
}

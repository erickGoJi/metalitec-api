using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportProductioncutting
    {
        public int ProductionCuttingId { get; set; }
        public string ProductionCutting { get; set; }
        public string ProductionCuttingDescription { get; set; }
        public DateTime ProductionCuttingDate { get; set; }
        public byte Complete { get; set; }
        public int? SupplierId { get; set; }
        public int? ContractId { get; set; }
        public string Contract { get; set; }
        public int? EmployeeId { get; set; }
        public string Employee { get; set; }
        public string ProductionCuttingNotes { get; set; }
    }
}

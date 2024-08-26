using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwProcessSearch
    {
        public int ProcessId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProcessType { get; set; }
        public string CostCode { get; set; }
        public double HourlyRate { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}

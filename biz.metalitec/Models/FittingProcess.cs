using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class FittingProcess
    {
        public int FittingProcessId { get; set; }
        public int FittingId { get; set; }
        public int ProcessId { get; set; }
        public double PerUnitQty { get; set; }
        public double To { get; set; }
        public double FixedMinutes { get; set; }
        public double PerUnitMinutes { get; set; }
        public string Notes { get; set; }
        public byte UnitTypeId { get; set; }
        public int Quantity { get; set; }

        public virtual Fitting Fitting { get; set; }
        public virtual Process Process { get; set; }
    }
}

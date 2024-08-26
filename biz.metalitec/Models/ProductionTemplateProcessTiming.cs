using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ProductionTemplateProcessTiming
    {
        public int ProductionTemplateProcessTimingId { get; set; }
        public int ProductionTemplateProcessId { get; set; }
        public int ItemLocationId { get; set; }
        public int? ProductionWorkStationId { get; set; }
        public int? Quantity { get; set; }
        public int? UnitTypeId { get; set; }
        public double? PerUnitQty { get; set; }
        public double? To { get; set; }
        /// <summary>
        /// Minutes, Hours, Days
        /// </summary>
        public byte? DisplayTimeUnitId { get; set; }
        public double? FixedMinutes { get; set; }
        public double? PerUnitMinutes { get; set; }
        public string Notes { get; set; }

        public virtual ItemLocation ItemLocation { get; set; }
        public virtual ProductionTemplateProcess ProductionTemplateProcess { get; set; }
        public virtual ProductionWorkStation ProductionWorkStation { get; set; }
    }
}

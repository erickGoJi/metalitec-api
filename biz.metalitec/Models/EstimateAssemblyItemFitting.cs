using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EstimateAssemblyItemFitting
    {
        public EstimateAssemblyItemFitting()
        {
            EstimateAssemblyItemFittingProcesses = new HashSet<EstimateAssemblyItemFittingProcess>();
        }

        public int EstimateAssemblyItemFittingId { get; set; }
        public int EstimateAssemblyItemId { get; set; }
        public int FittingId { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public double Area { get; set; }
        public double Value { get; set; }
        public double UnitPrice { get; set; }
        public int UnitId { get; set; }
        public int PriceSourceId { get; set; }
        public int CostCodeId { get; set; }
        public int? TempKey { get; set; }
        public int Version { get; set; }

        public virtual EstimateAssemblyItem EstimateAssemblyItem { get; set; }
        public virtual ICollection<EstimateAssemblyItemFittingProcess> EstimateAssemblyItemFittingProcesses { get; set; }
    }
}

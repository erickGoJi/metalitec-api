using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class EstimateCadlisting
    {
        public int EstimateCadlistingId { get; set; }
        public int EstimateId { get; set; }
        public int CadinterfaceId { get; set; }
        public string SourceItemCrossReference { get; set; }
        public string PlateItemCrossReference { get; set; }
        public int? ItemId { get; set; }
        public string Name { get; set; }
        public string SourceSectionSize { get; set; }
        public string SourceGrade { get; set; }
        public string SourceEstimateSubSection { get; set; }
        public string SourceQuantity { get; set; }
        public string SourceLength { get; set; }
        public string SourceWidth { get; set; }
        public string SourceThickness { get; set; }
        public string SourceDepth { get; set; }
        public string SourceUsage { get; set; }
        public byte? Ignore { get; set; }
        public int? UsageId { get; set; }
        public string TempLength { get; set; }
        public bool HasItemOnLoad { get; set; }
        public string SourceWeight { get; set; }
        public string SourceArea { get; set; }
        public string SourceReference { get; set; }
        public string SessionGuid { get; set; }
        public string CustomFields { get; set; }
        public string SourceGirderBfthickness { get; set; }
        public string SourceGirderBfwidth { get; set; }
        public string SourceGirderDepth { get; set; }
        public string SourceGirderShape { get; set; }
        public string SourceGirderTfthickness { get; set; }
        public string SourceGirderTfwidth { get; set; }
        public string SourceGirderType { get; set; }
        public string SourceGirderWebOffset { get; set; }
        public string SourceGirderWebThickness { get; set; }
        public string SourceSectionType { get; set; }
        public string SourcePaintFinish { get; set; }
        public string SourcePhase { get; set; }

        public virtual Estimate Estimate { get; set; }
    }
}

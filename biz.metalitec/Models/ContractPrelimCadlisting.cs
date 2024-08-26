using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractPrelimCadlisting
    {
        public int ContractPrelimCadlistingId { get; set; }
        public int ContractListingId { get; set; }
        public int CadinterfaceId { get; set; }
        public string SourceItemCrossReference { get; set; }
        public string PlateItemCrossReference { get; set; }
        public int? ItemId { get; set; }
        public string Name { get; set; }
        public string SourceSectionSize { get; set; }
        public string SourceGrade { get; set; }
        public string SourceMark { get; set; }
        public string SourceQuantity { get; set; }
        public double? SourceLength { get; set; }
        public double? SourceWidth { get; set; }
        public string SourceThickness { get; set; }
        public string SourceDepth { get; set; }
        public string SourcePhase { get; set; }
        public string SourcePaintFinish { get; set; }
        public string SourceDetails { get; set; }
        public byte Ignore { get; set; }
        public byte InvalidMark { get; set; }
        public string TempLength { get; set; }
        public bool HasItemOnLoad { get; set; }
        public string SourceLot { get; set; }
        public string SourceDrawing { get; set; }
        public string SourceWeight { get; set; }
        public string SourceArea { get; set; }
        public string SourceSectionCode { get; set; }
        public string SourceDueDate { get; set; }
        public string SessionGuid { get; set; }
        public string CustomFields { get; set; }
        public string SourceReference { get; set; }
        public bool CamSplitItem { get; set; }
        public string SourceSectionType { get; set; }
        public byte AllowRevision { get; set; }
        public int? ContractBatchId { get; set; }
        public string MarkStatus { get; set; }
        public int MinimumRevisibleStatus { get; set; }
        public string RevisionDetails { get; set; }
        public long RevisionIndex { get; set; }
        public int RevisionStatus { get; set; }
        public string SourceBottomFlangeGrade { get; set; }
        public string SourceBottomFlangeThickness { get; set; }
        public string SourceBottomFlangeWeld { get; set; }
        public string SourceBottomFlangeWidth { get; set; }
        public string SourceCambering { get; set; }
        public string SourceGirderBfthickness { get; set; }
        public string SourceGirderBfwidth { get; set; }
        public string SourceGirderDepth { get; set; }
        public string SourceGirderShape { get; set; }
        public string SourceGirderTfthickness { get; set; }
        public string SourceGirderTfwidth { get; set; }
        public string SourceGirderType { get; set; }
        public string SourceGirderWebOffset { get; set; }
        public string SourceGirderWebThickness { get; set; }
        public string SourceGrossLength { get; set; }
        public string SourceRadius { get; set; }
        public string SourceTopFlangeGrade { get; set; }
        public string SourceTopFlangeThickness { get; set; }
        public string SourceTopFlangeWeld { get; set; }
        public string SourceTopFlangeWidth { get; set; }
        public string SourceWebGrade { get; set; }
        public string SourceWebHeight { get; set; }
        public string SourceWebThickness { get; set; }
        public int StatusIndex { get; set; }
    }
}

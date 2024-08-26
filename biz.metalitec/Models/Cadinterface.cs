using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Cadinterface
    {
        /// <summary>
        /// Unique CAD Interface ID Number
        /// </summary>
        public int CadinterfaceId { get; set; }
        /// <summary>
        /// Name of the CAD Interface
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of the CAD Interface
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Type of CAD Interface
        /// </summary>
        public int CadInterfaceTypeId { get; set; }
        public byte Imperial { get; set; }
        /// <summary>
        /// The extension of the file you wish to import
        /// </summary>
        public string FileExtention { get; set; }
        /// <summary>
        /// The path of the file you wish to import
        /// </summary>
        public string DefaultFilePath { get; set; }
        /// <summary>
        /// The path that the imported file is to be archived to
        /// </summary>
        public string ArchiveFilePath { get; set; }
        public string MappingItemCrossReference { get; set; }
        public string MappingSectionSize { get; set; }
        public string MappingGrade { get; set; }
        /// <summary>
        /// The Subsection column within the file to be imported
        /// </summary>
        public string MappingEstimateSubSection { get; set; }
        public string MappingQuantity { get; set; }
        /// <summary>
        /// The Plate Width column within the file to be imported
        /// </summary>
        public string MappingWidth { get; set; }
        public string MappingUsage { get; set; }
        /// <summary>
        /// The Bar Length column within the file to be imported
        /// </summary>
        public string MappingLength { get; set; }
        public string MappingDepth { get; set; }
        public string MappingReference { get; set; }
        public string MappingMark { get; set; }
        public string MappingAmark { get; set; }
        public string MappingPrelimMark { get; set; }
        public string MappingPhase { get; set; }
        public string MappingLot { get; set; }
        public string MappingDetails { get; set; }
        public string MappingPaintFinish { get; set; }
        public string MappingCutType { get; set; }
        public string MappingStartWebAngle { get; set; }
        public string MappingEndWebAngle { get; set; }
        public string MappingUser1 { get; set; }
        /// <summary>
        /// Apply Labour Matrix
        /// </summary>
        public byte ApplyUsage { get; set; }
        /// <summary>
        /// Fittings mode setting
        /// </summary>
        public int FittingsMode { get; set; }
        public byte PlateLogic { get; set; }
        /// <summary>
        /// Specify the plate codes to search. Separate with commas to specify multiple codes (i.e. PLT,BL,PL,PLATE)
        /// </summary>
        public string PlateCode { get; set; }
        public byte PlateToFlat { get; set; }
        public byte PlateUseLimits { get; set; }
        public double PlateWidthLimit { get; set; }
        public double PlateThicknessLimit { get; set; }
        /// <summary>
        /// Specify the flat codes to search. Separate with commas to specify multiple codes (i.e. FLT,FLAT)
        /// </summary>
        public string FlatCode { get; set; }
        public byte FlatToPlate { get; set; }
        public byte FlatUseLimits { get; set; }
        public double FlatWidthLimit { get; set; }
        public double FlatThicknessLimit { get; set; }
        public string Script { get; set; }
        public string Notes { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        public int? Version { get; set; }
        public byte System { get; set; }
        public byte IgnoreColdRolled { get; set; }
        public byte ImportAsSiteAssembly { get; set; }
        public string MappingIsShaft { get; set; }
        public string MappingItemMark { get; set; }
        public string MappingMainMember { get; set; }
        public string MappingSiteMember { get; set; }
        public string MappingSiteMemberId { get; set; }
        public string MappingRevision { get; set; }
        public bool UseCadweight { get; set; }
        public bool UseCadarea { get; set; }
        public string MappingWeight { get; set; }
        public string MappingArea { get; set; }
        public bool? ReviseQuantityChanges { get; set; }
        public string MappingSectionCode { get; set; }
        public string MappingAssemblyId { get; set; }
        /// <summary>
        /// Is this CAD Interface Active?
        /// </summary>
        public bool? Active { get; set; }
        public string MappingDueDate { get; set; }
        public string MappingStartTopFlangeAngle { get; set; }
        public string MappingEndTopFlangeAngle { get; set; }
        public string MappingStartBottomFlangeAngle { get; set; }
        public string MappingEndBottomFlangeAngle { get; set; }
        public string CustomFields { get; set; }
        public string PlateConversionCode { get; set; }
        public string FlatConversionCode { get; set; }
        public string MappingAssemblyMarkGuid { get; set; }
        public string MappingMarkGuid { get; set; }
        public string MappingMarkItemGuid { get; set; }
        public string MappingModelType { get; set; }
        public string MappingGirderBfthickness { get; set; }
        public string MappingGirderBfwidth { get; set; }
        public string MappingGirderDepth { get; set; }
        public string MappingGirderShape { get; set; }
        public string MappingGirderTfthickness { get; set; }
        public string MappingGirderTfwidth { get; set; }
        public string MappingGirderType { get; set; }
        public string MappingGirderWebOffset { get; set; }
        public string MappingGirderWebThickness { get; set; }
        public string MappingSectionType { get; set; }
        public string MappingExecutionClass { get; set; }
        public string MappingBottomFlangeGrade { get; set; }
        public string MappingBottomFlangeThickness { get; set; }
        public string MappingBottomFlangeWeld { get; set; }
        public string MappingBottomFlangeWidth { get; set; }
        public string MappingCambering { get; set; }
        public string MappingGrossLength { get; set; }
        public string MappingRadius { get; set; }
        public string MappingTopFlangeGrade { get; set; }
        public string MappingTopFlangeThickness { get; set; }
        public string MappingTopFlangeWeld { get; set; }
        public string MappingTopFlangeWidth { get; set; }
        public string MappingWebGrade { get; set; }
        public string MappingWebHeight { get; set; }
        public string MappingWebThickness { get; set; }
        public string MappingContract { get; set; }
        public bool? UseNamedColumns { get; set; }
    }
}

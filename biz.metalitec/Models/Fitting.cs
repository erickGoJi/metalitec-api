using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Fitting
    {
        public Fitting()
        {
            EstimateItemFittings = new HashSet<EstimateItemFitting>();
            FittingProcesses = new HashSet<FittingProcess>();
        }

        /// <summary>
        /// The unique fitting ID number generated automatically.
        /// </summary>
        public int FittingId { get; set; }
        /// <summary>
        /// Name of fitting
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Give the fitting a description.
        /// </summary>
        public string Description { get; set; }
        public int ItemId { get; set; }
        public byte? DimensionalSize { get; set; }
        /// <summary>
        /// Apply same grade to fitting as the shaft.
        /// </summary>
        public byte? GradeAsShaft { get; set; }
        /// <summary>
        /// Define the width of the fitting as a percentage of the shaft depth.
        /// </summary>
        public double DepthWidthPercent { get; set; }
        /// <summary>
        /// Define the width of the fitting as an addition to a percentage of the shafts depth.
        /// </summary>
        public double DepthWidthDimension { get; set; }
        /// <summary>
        /// Define the thickness of the fitting as a percentage of the shaft depth.
        /// </summary>
        public double DepthThickPercent { get; set; }
        /// <summary>
        /// Define the thickness of the fitting as an addition to a percentage of the shafts depth.
        /// </summary>
        public double DepthThickDimension { get; set; }
        /// <summary>
        /// Define the length of the fitting as a percentage of the shaft depth.
        /// </summary>
        public double DepthLengthPercent { get; set; }
        /// <summary>
        /// Define the length of the fitting as an addition to a percentage of the shafts depth.
        /// </summary>
        public double DepthLengthDimension { get; set; }
        /// <summary>
        /// Define the width of the fitting as a percentage of the shafts width.
        /// </summary>
        public double WidthWidthPercent { get; set; }
        /// <summary>
        /// Define the width of the fitting as an addition to a percentage of the shafts width.
        /// </summary>
        public double WidthWidthDimension { get; set; }
        /// <summary>
        /// Define the thickness of the fitting as a percentage of the shafts width.
        /// </summary>
        public double WidthThickPercent { get; set; }
        /// <summary>
        /// Define the thickness of the fitting as an addition to a percentage of the shafts width.
        /// </summary>
        public double WidthThickDimension { get; set; }
        /// <summary>
        /// Define the length of the fitting as a percentage of the shafts width.
        /// </summary>
        public double WidthLengthPercent { get; set; }
        /// <summary>
        /// Define the length of the fitting as an addition to a percentage of the shafts width.
        /// </summary>
        public double WidthLengthDimension { get; set; }
        /// <summary>
        /// Define the width of the fitting as a percentage of the shafts flange thickness.
        /// </summary>
        public double ThickFlangeWidthPercent { get; set; }
        /// <summary>
        /// Define the width of the fitting as an addition to a percentage of the shafts flange thickness.
        /// </summary>
        public double ThickFlangeWidthDimension { get; set; }
        /// <summary>
        /// Define the thickness of the fitting as a percentage of the shafts flange thickness.
        /// </summary>
        public double ThickFlangeThickPercent { get; set; }
        /// <summary>
        /// Define the thickness of the fitting as an addition to a percentage of the shafts flange thickness.
        /// </summary>
        public double ThickFlangeThickDimension { get; set; }
        /// <summary>
        /// Define the length of the fitting as a percentage of the shafts flange thickness.
        /// </summary>
        public double ThickFlangeLengthPercent { get; set; }
        /// <summary>
        /// Define the length of the fitting as an addition to a percentage of the shafts flange thickness.
        /// </summary>
        public double ThickFlangeLengthDimension { get; set; }
        /// <summary>
        /// Define the width of the fitting as a percentage of the shafts web width.
        /// </summary>
        public double ThickWebWidthPercent { get; set; }
        /// <summary>
        /// Define the width of the fitting as an addition to a percentage of the shafts web width.
        /// </summary>
        public double ThickWebWidthDimension { get; set; }
        /// <summary>
        /// Define the thickness of the fitting as a percentage of the shafts web width.
        /// </summary>
        public double ThickWebThickPercent { get; set; }
        /// <summary>
        /// Define the thickness of the fitting as an addition to a percentage of the shafts web width.
        /// </summary>
        public double ThickWebThickDimension { get; set; }
        /// <summary>
        /// Define the length of the fitting as a percentage of the shafts web width.
        /// </summary>
        public double ThickWebLengthPercent { get; set; }
        /// <summary>
        /// Define the length of the fitting as an addition to a percentage of the shafts web width.
        /// </summary>
        public double ThickWebLengthDimension { get; set; }
        /// <summary>
        /// Define the width of the fitting by a fixed dimension.
        /// </summary>
        public double? FixedSizeWidth { get; set; }
        /// <summary>
        /// Define the thickness of the fitting by a fixed dimension.
        /// </summary>
        public double? FixedSizeThick { get; set; }
        /// <summary>
        /// Define the length of the fitting by a fixed dimension.
        /// </summary>
        public double? FixedSizeLength { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public byte Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        /// <summary>
        /// Define the width of the fitting as a percentage of the shafts length.
        /// </summary>
        public double LengthWidthPercent { get; set; }
        /// <summary>
        /// Define the width of the fitting as an addition to a percentage of the shafts length.
        /// </summary>
        public double LengthWidthDimension { get; set; }
        /// <summary>
        /// Define the thickness of the fitting as a percentage of the shafts length.
        /// </summary>
        public double LengthThickPercent { get; set; }
        /// <summary>
        /// Define the thickness of the fitting as an addition to a percentage of the shafts length.
        /// </summary>
        public double LengthThickDimension { get; set; }
        /// <summary>
        /// Define the length of the fitting as a percentage of the shafts length.
        /// </summary>
        public double LengthLengthPercent { get; set; }
        /// <summary>
        /// Define the length of the fitting as an addition to a percentage of the shafts length.
        /// </summary>
        public double LengthLengthDimension { get; set; }
        public int FacilityId { get; set; }

        public virtual Facility Facility { get; set; }
        public virtual Item Item { get; set; }
        public virtual ICollection<EstimateItemFitting> EstimateItemFittings { get; set; }
        public virtual ICollection<FittingProcess> FittingProcesses { get; set; }
    }
}

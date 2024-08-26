using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Nesting
    {
        /// <summary>
        /// Unique Nesting Option ID
        /// </summary>
        public int NestingId { get; set; }
        /// <summary>
        /// Name of Nesting Option
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Cost Optimization Mode - If Checked, switches optimizer objective to minimize total cost of used stock items, from material length total wastage; Unchecked will revert to material length total wastage.
        /// </summary>
        public bool CostOptimiseMode { get; set; }
        /// <summary>
        /// Ignore Last Stock - exclude last filled (half-empty) stock item from optimization objective and presented totals (if appropriate waste is greater than Minimal Reusable Length).
        /// </summary>
        public byte IgnoreLast { get; set; }
        /// <summary>
        /// Optimizer Effort Level - the slower this option is set to the longer nesting will take, however as it attempts more permutations it should lead to more efficient nesting.
        /// </summary>
        public int OptimiseEffortLevel { get; set; }
        /// <summary>
        /// Moving the slider to Less Layouts reduces the amount of different nesting plans,however it may nest to more bars and lead to increased wastage.
        /// </summary>
        public int LowerLayout { get; set; }
        /// <summary>
        /// Short Length preference forces the nesting engine to use shorter rather than longer length bars. Ideal when clearing out short offcuts from Inventory.
        /// </summary>
        public int PreferShortStock { get; set; }
        /// <summary>
        /// ~Maximum Different Stocks - maximum number of different stock types (sizes) allowed to be actually used from the list of available stock material (enter zero “0”, if any number is allowed).
        /// </summary>
        public int MaxDiffStock { get; set; }
        /// <summary>
        /// ~Maximum Different Pieces; Maximum number of different piece kinds (sizes) allowed to be placed together in the same layout/pattern (enter zero “0”, if any number is allowed).
        /// </summary>
        public int MaxDiffPiece { get; set; }
        /// <summary>
        /// Minimum Reusable Lengths; Length of shortest offcut piece (remainder) from resulting layouts that should be returned to stock inventory list as a response to “Add Reusable” command.
        /// </summary>
        public int MinReuseLength { get; set; }
        /// <summary>
        /// Saw Blade Thickness - gaps between items (saw kerf).
        /// </summary>
        public double SawBladeThick { get; set; }
        /// <summary>
        /// Gripping / End-zone; Stock piece end portion, which due to a certain cutting technology reasons must be either free of saw cuts (gripping end), or can not be utilized at all, say, for trim losses (left and right sum). 
        /// </summary>
        public double GripEndZone { get; set; }
        /// <summary>
        /// Non Usable End-Zone, The way program treats the Gripping End Zone constraint. Usable / Non Usable.
        /// </summary>
        public bool NonUseEndZone { get; set; }
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
        /// <summary>
        /// Internal Key to Identity Nesting Option required by the StruMIS System
        /// </summary>
        public int? System { get; set; }
        public double? MillMinLength { get; set; }
        public double? MillMaxLength { get; set; }
        public double? MillLengthIncrement { get; set; }
        public byte NestingEngine { get; set; }
        public double AngleFillerGap { get; set; }
        public byte InventoryAge { get; set; }
        /// <summary>
        /// Whether to respect the original offcut length/shape or re-nest the entire bar/sheet
        /// </summary>
        public byte NestToTheoreticalOffcut { get; set; }
        public double? BottomEdgeClearance { get; set; }
        public double? LeftEdgeClearance { get; set; }
        public double? MillMaxPlength { get; set; }
        public double? MillMaxPwidth { get; set; }
        public double? MillMinPlength { get; set; }
        public double? MillMinPwidth { get; set; }
        public double? MillPlengthIncrement { get; set; }
        public double? MillPwidthIncrement { get; set; }
        public double? RightEdgeClearance { get; set; }
        public bool? RoundToNextIncrement { get; set; }
        public bool? RoundToNextPincrement { get; set; }
        public double? TopEdgeClearance { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractItem
    {
        public ContractItem()
        {
            ContractItemCams = new HashSet<ContractItemCam>();
            ContractMarkItems = new HashSet<ContractMarkItem>();
            ContractMarkPhaseLotItems = new HashSet<ContractMarkPhaseLotItem>();
            ProductionWorkOrderContractArchives = new HashSet<ProductionWorkOrderContractArchive>();
            ProductionWorkOrderContracts = new HashSet<ProductionWorkOrderContract>();
        }

        public int ContractItemId { get; set; }
        public int ItemId { get; set; }
        public int ContractListingId { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Shaft, Fitting, Other
        /// </summary>
        public int MarkItemTypeId { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double UnitWeight { get; set; }
        public double UnitArea { get; set; }
        public string Reference { get; set; }
        public int CutTypeId { get; set; }
        public string CamFile { get; set; }
        public bool? ExactDimensions { get; set; }
        public double StartWebAngle { get; set; }
        public double EndWebAngle { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string User3 { get; set; }
        public int Version { get; set; }
        public string RevisedBy { get; set; }
        public bool NotNeededForAssembly { get; set; }
        public double StartTopFlangeAngle { get; set; }
        public double EndTopFlangeAngle { get; set; }
        public double StartBottomFlangeAngle { get; set; }
        public double EndBottomFlangeAngle { get; set; }
        public byte? RnU { get; set; }
        public string BottomFlangeGrade { get; set; }
        public double BottomFlangeThickness { get; set; }
        public string BottomFlangeWeld { get; set; }
        public double BottomFlangeWidth { get; set; }
        public double Cambering { get; set; }
        /// <summary>
        /// ~~(0=Standard Mark Item, 1=Cam Split Item, 2=Combined Mark Item)
        /// </summary>
        public byte ContractItemType { get; set; }
        public double GrossLength { get; set; }
        public double Radius { get; set; }
        public string TopFlangeGrade { get; set; }
        public double TopFlangeThickness { get; set; }
        public string TopFlangeWeld { get; set; }
        public double TopFlangeWidth { get; set; }
        public string WebGrade { get; set; }
        public double WebHeight { get; set; }
        public double WebThickness { get; set; }

        public virtual Item Item { get; set; }
        public virtual ICollection<ContractItemCam> ContractItemCams { get; set; }
        public virtual ICollection<ContractMarkItem> ContractMarkItems { get; set; }
        public virtual ICollection<ContractMarkPhaseLotItem> ContractMarkPhaseLotItems { get; set; }
        public virtual ICollection<ProductionWorkOrderContractArchive> ProductionWorkOrderContractArchives { get; set; }
        public virtual ICollection<ProductionWorkOrderContract> ProductionWorkOrderContracts { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ContractDetailedCadlistingRevalidate
    {
        public int? ContractDetailedCadlistingId { get; set; }
        public string Name { get; set; }
        public string SourceItemCrossReference { get; set; }
        public string SourceSectionSize { get; set; }
        public int? ItemId { get; set; }
        public string SourceGrade { get; set; }
        public string SourceAmark { get; set; }
        public string SourceMark { get; set; }
        public string SourceItemMark { get; set; }
        public double? SourceQuantity { get; set; }
        public double? SourceLength { get; set; }
        public double? SourceWidth { get; set; }
        public string SourceCambering { get; set; }
        public string SourceRadius { get; set; }
        public string SourceMainMember { get; set; }
        public string SourcePhase { get; set; }
        public string SourcePaintFinish { get; set; }
        public string SourceLot { get; set; }
        public byte? Ignore { get; set; }
        public int? IdBasedOff { get; set; }
        public string SessionGuid { get; set; }
        public int? SessionGuidChk { get; set; }
    }
}

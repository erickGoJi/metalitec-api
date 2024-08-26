using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportContractmark
    {
        public int ContractMarkId { get; set; }
        public string Drawing { get; set; }
        public bool AssemblyMark { get; set; }
        public bool SiteAssembled { get; set; }
        public string Mark { get; set; }
        public string MarkDescription { get; set; }
        public string MainMemberItemName { get; set; }
        public double? MainMemberLength { get; set; }
        public double? MainMemberWidth { get; set; }
        public double MarkQuantity { get; set; }
        public string ParentMark { get; set; }
        public double MarkWeight { get; set; }
        public double MarkArea { get; set; }
        public string PaintFinish { get; set; }
        public string CadFile { get; set; }
        public bool OnHold { get; set; }
        public string OnHoldNotes { get; set; }
        public string MarkNotes { get; set; }
        public string MarkRevisedBy { get; set; }
        public double MarkUnitArea { get; set; }
        public double MarkUnitWeight { get; set; }
        public int ContractId { get; set; }
    }
}

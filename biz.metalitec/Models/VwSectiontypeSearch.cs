using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwSectiontypeSearch
    {
        public int SectionTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public byte Grades { get; set; }
        public byte Linear { get; set; }
        public string DstvProfile { get; set; }
        public string Procurement { get; set; }
        public bool? CreateProductionWorkOrder { get; set; }
        public string Region { get; set; }
        public string RollType { get; set; }
        public string PriceUnit { get; set; }
        public string WeightCalculation { get; set; }
        public byte Enabled { get; set; }
        public bool AlwaysDisplayIndividualInstancesWhenNesting { get; set; }
        public string ScrapType { get; set; }
        public int? ScrapTypeId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class NestingResultItemDesign
    {
        public int NestingResultItemDesignId { get; set; }
        public string ShapeDesignType { get; set; }
        public string ShapeDesignData { get; set; }
        public int Chksum { get; set; }
    }
}

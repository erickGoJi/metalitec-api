using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class GradeCrossReference
    {
        public int GradeCrossReferenceId { get; set; }
        public int GradeId { get; set; }
        public string Name { get; set; }
    }
}

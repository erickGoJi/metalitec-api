using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SectionTypeGrade
    {
        public int SectionTypeId { get; set; }
        public int GradeId { get; set; }
        public byte Default { get; set; }
    }
}

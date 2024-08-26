using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwGradeSearch
    {
        public int GradeId { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public int Rating { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

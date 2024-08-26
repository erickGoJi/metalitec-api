using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class LottingDateDependency
    {
        public int LottingDateDepenanciesId { get; set; }
        public string LottingDate { get; set; }
        public string DependentDate { get; set; }
    }
}

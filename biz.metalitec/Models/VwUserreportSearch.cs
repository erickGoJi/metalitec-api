﻿using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportSearch
    {
        public int UserReportId { get; set; }
        public int SystemModuleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwQsCategorySearch
    {
        public int QscategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryType { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
    }
}

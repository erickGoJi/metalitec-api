using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportRole
    {
        public int RoleId { get; set; }
        public string Role { get; set; }
        public string SystemObject { get; set; }
        public int? Admin { get; set; }
        public int? Read { get; set; }
        public int? Insert { get; set; }
        public int? Update { get; set; }
        public int? Delete { get; set; }
        public int? Share { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class RoleObject
    {
        public int RoleObjectId { get; set; }
        public int RoleId { get; set; }
        public int SystemObjectId { get; set; }
        public int Admin { get; set; }
        public int Read { get; set; }
        public int Insert { get; set; }
        public int Update { get; set; }
        public int Delete { get; set; }
        public int Share { get; set; }
        public byte System { get; set; }

        public virtual Role Role { get; set; }
        public virtual SystemObject SystemObject { get; set; }
    }
}

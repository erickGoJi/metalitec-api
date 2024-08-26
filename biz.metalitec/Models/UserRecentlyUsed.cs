using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class UserRecentlyUsed
    {
        public int UserRecentlyUsedId { get; set; }
        public int UserId { get; set; }
        public int SystemObjectId { get; set; }
        public int SystemObjectKey { get; set; }
        public DateTime? UsedAt { get; set; }
        public string Name { get; set; }
    }
}

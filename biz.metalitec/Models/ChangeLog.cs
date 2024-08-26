using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class ChangeLog
    {
        public int Id { get; set; }
        public string ObjectName { get; set; }
        public string ObjectSchema { get; set; }
        public string ObjectType { get; set; }
        public string EventType { get; set; }
        public string UserName { get; set; }
        public DateTime? EventDate { get; set; }
        public string EventScript { get; set; }
    }
}

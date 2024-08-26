using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Activitylog
    {
        public string Username { get; set; }
        public string Object { get; set; }
        public string Action { get; set; }
        public string ProcedureName { get; set; }
        public DateTime Date { get; set; }
        public byte? Granted { get; set; }
    }
}

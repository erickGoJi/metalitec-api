using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Errorlog
    {
        public string Operation { get; set; }
        public DateTime? ErrDate { get; set; }
        public string ErrorMessage { get; set; }
        public int? ErrorNumber { get; set; }
        public int? ErrorSeverity { get; set; }
        public int? ErrorState { get; set; }
        public int? ErrorLine { get; set; }
        public string ErrorProcedure { get; set; }
        public int Rw { get; set; }
    }
}

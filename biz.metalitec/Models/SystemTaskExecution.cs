using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemTaskExecution
    {
        public int SystemTaskExecutionId { get; set; }
        public int? SystemTaskId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        /// <summary>
        /// ~1 - Running , 2 - Sucess , 3 - Error
        /// </summary>
        public int? Status { get; set; }
        public string Message { get; set; }

        public virtual SystemTask SystemTask { get; set; }
    }
}

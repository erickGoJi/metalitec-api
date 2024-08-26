using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class VwUserreportSystemtaskexecution
    {
        public int SystemTaskExecutionId { get; set; }
        public string SystemTask { get; set; }
        public string SystemTaskDescription { get; set; }
        public string TaskType { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Message { get; set; }
    }
}

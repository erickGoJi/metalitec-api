using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemTask
    {
        public SystemTask()
        {
            SystemTaskExecutions = new HashSet<SystemTaskExecution>();
        }

        public int SystemTaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? TaskType { get; set; }
        public string ScriptText { get; set; }
        public string Backuplocation { get; set; }
        public DateTime? NextRunDate { get; set; }
        /// <summary>
        /// ~1 - Once, 2 - Daily,3 - Weekly,4 - Monthly
        /// </summary>
        public int? RunType { get; set; }
        public int? RunInterval { get; set; }
        public int? RunDayType { get; set; }
        public int? RunDayInterval { get; set; }
        /// <summary>
        /// ~1 - Specific day of the month; 2 - End of month
        /// </summary>
        public int? RunMonthType { get; set; }
        public int? RunMonthDay { get; set; }
        public DateTime? RunTime { get; set; }
        public byte? Sunday { get; set; }
        public byte? Monday { get; set; }
        public byte? Tuesday { get; set; }
        public byte? Wednesday { get; set; }
        public byte? Thursday { get; set; }
        public byte? Friday { get; set; }
        public byte? Saturday { get; set; }
        public byte? Enabled { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? Version { get; set; }
        public byte? System { get; set; }
        public int? TransactionInterfaceId { get; set; }
        public string ExcelTemplate { get; set; }
        public int? ReportId { get; set; }
        public int? ReportOutput { get; set; }
        public string ReportParameters { get; set; }
        public string ReportPath { get; set; }
        public int? ReportTemplateFacilityId { get; set; }
        public string EmailTemplate { get; set; }
        /// <summary>
        /// Half,Quarter,Eighth,Sixteenth,ThirtySecondth
        /// </summary>
        public int? MeasureDenominator { get; set; }
        /// <summary>
        /// Imperial,Metric,ImperialInch
        /// </summary>
        public int? MeasureUnit { get; set; }
        public DateTime? RunFromDate { get; set; }
        public DateTime? RunToDate { get; set; }
        /// <summary>
        /// (Kg) Kilograms,(T) Metric Tonnes,(lb) Pounds,(t) Tons
        /// </summary>
        public int? WeightUnit { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<SystemTaskExecution> SystemTaskExecutions { get; set; }
    }
}

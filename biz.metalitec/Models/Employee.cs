using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeHourlyRates = new HashSet<EmployeeHourlyRate>();
            EmployeeProcesses = new HashSet<EmployeeProcess>();
            EmployeeTimesheetArchives = new HashSet<EmployeeTimesheetArchive>();
            EmployeeTimesheets = new HashSet<EmployeeTimesheet>();
            ProductionProposedMovements = new HashSet<ProductionProposedMovement>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string Name { get; set; }
        public int CostCodeId { get; set; }
        public byte Active { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public DateTime UpdatedOn { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime CreatedOn { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public int? ContactId { get; set; }
        public int FacilityId { get; set; }

        public virtual CostCode CostCode { get; set; }
        public virtual Facility Facility { get; set; }
        public virtual ICollection<EmployeeHourlyRate> EmployeeHourlyRates { get; set; }
        public virtual ICollection<EmployeeProcess> EmployeeProcesses { get; set; }
        public virtual ICollection<EmployeeTimesheetArchive> EmployeeTimesheetArchives { get; set; }
        public virtual ICollection<EmployeeTimesheet> EmployeeTimesheets { get; set; }
        public virtual ICollection<ProductionProposedMovement> ProductionProposedMovements { get; set; }
    }
}

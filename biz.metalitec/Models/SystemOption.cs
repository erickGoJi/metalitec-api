using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class SystemOption
    {
        public int SystemOptionId { get; set; }
        public int SystemModuleId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public byte ValueControlType { get; set; }
        public bool IsNumeric { get; set; }
        public string Notes { get; set; }
        public byte? System { get; set; }
        /// <summary>
        /// ~Foreign Key from System Options Group table.
        /// </summary>
        public int SystemOptionGroupId { get; set; }
        public int BitValue { get; set; }
        public int? MaxLength { get; set; }

        public virtual SystemOptionGroup SystemOptionGroup { get; set; }
    }
}

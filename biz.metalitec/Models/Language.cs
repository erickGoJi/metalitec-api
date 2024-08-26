using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class Language
    {
        public Language()
        {
            LanguageStringTranslations = new HashSet<LanguageStringTranslation>();
        }

        /// <summary>
        /// The unique language ID number generated automatically.
        /// </summary>
        public int LanguageId { get; set; }
        /// <summary>
        /// Define the language name.
        /// </summary>
        public string Name { get; set; }
        public string Code { get; set; }
        /// <summary>
        /// The date of the last update.
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// The last updater
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// Date the record was created.
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// The record creator
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        public byte Rtllanguage { get; set; }
        public byte System { get; set; }
        public string Iso6391code { get; set; }
        public bool Iso6391codeInUse { get; set; }
        public int RegionalSettingId { get; set; }

        public virtual ICollection<LanguageStringTranslation> LanguageStringTranslations { get; set; }
    }
}

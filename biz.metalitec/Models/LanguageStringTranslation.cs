using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class LanguageStringTranslation
    {
        /// <summary>
        /// Unique ID
        /// </summary>
        public int LanguageTranslationId { get; set; }
        /// <summary>
        /// Language ID
        /// </summary>
        public int LanguageId { get; set; }
        /// <summary>
        /// Language String ID
        /// </summary>
        public int LanguageStringId { get; set; }
        /// <summary>
        /// System String
        /// </summary>
        public string SystemString { get; set; }
        /// <summary>
        /// Translated String
        /// </summary>
        public string TranslatedString { get; set; }
        /// <summary>
        /// Created By
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// CreatedOn
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy
        /// </summary>
        public string UpdatedBy { get; set; }
        /// <summary>
        /// UpdatedOn
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        public int? Chksum { get; set; }
        public int? SystemTranslation { get; set; }

        public virtual Language Language { get; set; }
    }
}

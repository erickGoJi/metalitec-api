using System;
using System.Collections.Generic;

namespace biz.metalitec.Models
{
    public partial class QsanalysisCategory
    {
        public QsanalysisCategory()
        {
            QsanalysisCategoryRules = new HashSet<QsanalysisCategoryRule>();
            QsanalysisCategoryUnits = new HashSet<QsanalysisCategoryUnit>();
            QsanalysisListings = new HashSet<QsanalysisListing>();
            SalesInvoiceItems = new HashSet<SalesInvoiceItem>();
        }

        public int QsanalysisCategoryId { get; set; }
        public int QsanalysisId { get; set; }
        /// <summary>
        /// Category Name e.g. &quot;All Beams&quot;
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Long Description of Category
        /// </summary>
        public string Description { get; set; }
        public int UnitId { get; set; }
        /// <summary>
        /// The Total Weight of All Items that fall into the category
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// The Area Weight of All Items that fall into the category
        /// </summary>
        public double Area { get; set; }
        /// <summary>
        /// Calculated Using the Category Unit and Unit Price
        /// </summary>
        public double CostValue { get; set; }
        public double CostUnitValue { get; set; }
        /// <summary>
        /// Calculated Sell Value for the Category
        /// </summary>
        public double SellValue { get; set; }
        public double SellUnitValue { get; set; }
        public string Notes { get; set; }
        /// <summary>
        /// Order to be displayed and reported
        /// </summary>
        public int SortOrder { get; set; }
        public int? TempKey { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public int Version { get; set; }
        public int? CategoryTypeId { get; set; }

        public virtual Qsanalysis Qsanalysis { get; set; }
        public virtual ICollection<QsanalysisCategoryRule> QsanalysisCategoryRules { get; set; }
        public virtual ICollection<QsanalysisCategoryUnit> QsanalysisCategoryUnits { get; set; }
        public virtual ICollection<QsanalysisListing> QsanalysisListings { get; set; }
        public virtual ICollection<SalesInvoiceItem> SalesInvoiceItems { get; set; }
    }
}

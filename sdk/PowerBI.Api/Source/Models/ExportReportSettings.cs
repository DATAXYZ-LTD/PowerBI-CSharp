// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Export to file request settings
    /// </summary>
    public partial class ExportReportSettings
    {
        /// <summary>
        /// Initializes a new instance of the ExportReportSettings class.
        /// </summary>
        public ExportReportSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExportReportSettings class.
        /// </summary>
        /// <param name="locale">The locale to apply</param>
        /// <param name="includeHiddenPages">A flag indicating whether to
        /// include hidden pages when exporting the entire report (when passing
        /// specific pages this property will be ignored). If not provided, the
        /// default behavior is to exclude hidden pages</param>
        public ExportReportSettings(string locale = default(string), bool? includeHiddenPages = default(bool?))
        {
            Locale = locale;
            IncludeHiddenPages = includeHiddenPages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the locale to apply
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating whether to include hidden pages when
        /// exporting the entire report (when passing specific pages this
        /// property will be ignored). If not provided, the default behavior is
        /// to exclude hidden pages
        /// </summary>
        [JsonProperty(PropertyName = "includeHiddenPages")]
        public bool? IncludeHiddenPages { get; set; }

    }
}

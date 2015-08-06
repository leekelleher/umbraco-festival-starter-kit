using Our.Umbraco.Ditto;

namespace Our.Umbraco.FestivalStarterKit.App_Code.Models
{
    public class Section : global::Umbraco.Core.Models.PublishedContent.PublishedContentModel
    {
        public Section(global::Umbraco.Core.Models.IPublishedContent content) : base(content)
        {
        }

        [UmbracoProperty("UrlName")]
        public string Alias { get; set; }

        [UmbracoProperty("UrlName")]
        public string CssClass { get; set; }

        [UmbracoProperty("DocumentTypeAlias")]
        public string Type { get; set; }
    }
}
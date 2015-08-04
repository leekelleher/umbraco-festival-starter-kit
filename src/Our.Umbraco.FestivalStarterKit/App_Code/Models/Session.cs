using Our.Umbraco.Ditto;
using System.Collections.Generic;
using System.Web;

namespace Our.Umbraco.FestivalStarterKit.App_Code.Models
{
    public class Session
    {
        [UmbracoProperty("title", "Name")]
        public string Title { get; set; }

        public string Time { get; set; }

        public HtmlString Description { get; set; }

        [UmbracoProperty("DocumentTypeAlias")]
        public string SessionType { get; set; }

        [UmbracoProperty("Children")]
        public virtual IEnumerable<Speaker> Speakers { get; set; }
    }
}
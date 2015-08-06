using Our.Umbraco.Ditto;

namespace Our.Umbraco.FestivalStarterKit.App_Code.Models
{
    public class MenuLink
    {
        [UmbracoProperty("Name")]
        public string Label { get; set; }

        public string Url { get; set; }
    }
}
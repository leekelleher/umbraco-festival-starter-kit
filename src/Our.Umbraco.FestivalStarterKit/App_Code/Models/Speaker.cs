using Our.Umbraco.Ditto;
using Umbraco.Core.Models;

namespace Our.Umbraco.FestivalStarterKit.App_Code.Models
{
    public class Speaker
    {
        public string SpeakerName { get; set; }

        public string SpeakerPhoto { get; set; }

        public string SpeakerBio { get; set; }

        public string SpeakerCompany { get; set; }

        public string SpeakerLinkText { get; set; }

        public string SpeakerLinkUrl { get; set; }

        [UmbracoProperty("Parent")]
        public virtual Session Session { get; set; }
    }
}
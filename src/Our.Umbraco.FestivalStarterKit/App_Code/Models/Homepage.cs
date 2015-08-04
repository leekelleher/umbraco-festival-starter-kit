using Our.Umbraco.Ditto;

namespace Our.Umbraco.FestivalStarterKit.App_Code.Models
{
    public class Homepage
    {
        public string FestivalName { get; set; }

        public string FestivalDescription { get; set; }

        // TODO: [LK] Add this to the homepage node
        public string VenueAddress { get; set; }

        public string TicketPrice { get; set; }

        [UmbracoProperty("Url")]
        public string SiteUrl { get; set; }

        public string GoogleAnalytics { get; set; }

        public string LinkText { get; set; }

        public string LinkUrl { get; set; }
    }
}
using Our.Umbraco.Ditto;
using System.Collections.Generic;
using Umbraco.Core.Models;

namespace Our.Umbraco.FestivalStarterKit.App_Code.Models
{
    public class SponsorsSection
    {
        public string Name { get; set; }

        [UmbracoProperty("Children")]
        public virtual IEnumerable<Sponsor> Sponsors { get; set; }
    }
}
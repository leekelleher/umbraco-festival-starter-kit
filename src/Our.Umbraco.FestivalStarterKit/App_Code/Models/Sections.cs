using Our.Umbraco.Ditto;
using Our.Umbraco.FestivalStarterKit.App_Code.ValueResolvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Our.Umbraco.FestivalStarterKit.App_Code.Models
{
    public class Sections
    {
        [DittoValueResolver(typeof(SectionValueResolver))]
        public IEnumerable<Section> SectionItems { get; set; }
    }
}
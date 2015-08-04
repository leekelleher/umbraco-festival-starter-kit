using Our.Umbraco.Ditto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Our.Umbraco.FestivalStarterKit.App_Code.Models
{
    public class ScheduleSection
    {
        public string Name { get; set; }

        public HtmlString Intro { get; set; }

        [UmbracoProperty("Children")]
        public virtual IEnumerable<Session> Sessions { get; set; }
    }
}
using Our.Umbraco.Ditto;
using System.Collections.Generic;
using System.ComponentModel;

namespace Our.Umbraco.FestivalStarterKit.App_Code.Models
{
    public class SpeakersSection
    {
        public string Name { get; set; }
        
        [TypeConverter(typeof(DittoPickerConverter))]
        public IEnumerable<Speaker> FeaturedSpeakers { get; set; }
    }
}
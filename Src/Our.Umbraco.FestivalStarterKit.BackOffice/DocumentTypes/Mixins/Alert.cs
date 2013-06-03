using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes.Mixins
{
	public class Alert
	{
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Page Alert Title", Description = "", Tab = Tabs.Alert, Mandatory = false)]
        public string PageAlertTitle { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.TextboxMultiple, Name = "Alert", Description = "", Tab = Tabs.Alert, Mandatory = false)]
		public string PageAlert { get; set; }
	}
}
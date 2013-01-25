using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes.Mixins
{
	public class Content
	{
		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Page Title", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public string PageTitle { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.RichtextEditor, Name = "Page Text", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public HtmlString PageText { get; set; }
	}
}
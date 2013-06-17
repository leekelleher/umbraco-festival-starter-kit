using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "SpeakerPage", IconUrl = "folder.gif",
		Alias = "SpeakerPage",
		AllowedTemplates = new string[] { "SpeakerPage" },
		AllowedChildNodeTypes = new Type[] { })]
	public partial class SpeakerPage : FestivalStarterKit
	{
		#region ctor

		public SpeakerPage() { }
		public SpeakerPage(int nodeId) : base(nodeId) { }

		#endregion

		#region Content

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Page Title", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public string PageTitle { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.Upload, Name = "Speaker Photo", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public string SpeakerPhoto { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.RichtextEditor, Name = "Page Text", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public HtmlString PageText { get; set; }

		#endregion

		#region Social

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Twitter", Description = "", Tab = Tabs.Social, Mandatory = false)]
		public string Twitter { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Facebook", Description = "", Tab = Tabs.Social, Mandatory = false)]
		public string Facebook { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "LinkedIn", Description = "", Tab = Tabs.Social, Mandatory = false)]
		public string LinkedIn { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Google+", Description = "", Tab = Tabs.Social, Mandatory = false)]
		public string Google { get; set; }

		#endregion
	}
}
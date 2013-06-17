using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "FAQ", IconUrl = "folder.gif",
		Alias = "Faq",
		AllowedTemplates = new string[] { },
		AllowedChildNodeTypes = new Type[] { })]
	public partial class Faq : FestivalStarterKit
	{
		#region ctor

		public Faq() { }
		public Faq(int nodeId) : base(nodeId) { }

		#endregion

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Question", Description = "", Tab = Tabs.Content, Mandatory = true)]
		public string PageTitle { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.RichtextEditor, Name = "Answer", Description = "", Tab = Tabs.Content, Mandatory = true)]
		public HtmlString PageText { get; set; }
	}
}
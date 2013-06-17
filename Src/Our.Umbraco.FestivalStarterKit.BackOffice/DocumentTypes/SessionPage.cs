using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Our.Umbraco.FestivalStarterKit.BackOffice.DataTypes;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "SessionPage", IconUrl = "folder.gif",
		Alias = "SessionPage",
		AllowedTemplates = new string[] { "SessionPage" },
		AllowedChildNodeTypes = new Type[] { })]
	public partial class SessionPage : FestivalStarterKit
	{
		#region ctor

		public SessionPage() { }
		public SessionPage(int nodeId) : base(nodeId) { }

		#endregion

		#region Content

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Page Title", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public string PageTitle { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.RichtextEditor, Name = "Page Text", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public HtmlString PageText { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.Other, OtherTypeName = SpeakerPicker.Name, Name = "Speaker", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public int Speaker { get; set; }

		#endregion
	}
}
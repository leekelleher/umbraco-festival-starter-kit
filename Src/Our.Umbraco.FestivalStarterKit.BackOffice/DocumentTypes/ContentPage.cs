using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "ContentPage", IconUrl = "folder.gif",
		Alias = "ContentPage",
		AllowedTemplates = new string[] { "ContentPage" },
		AllowedChildNodeTypes = new Type[] { typeof(ContentPage) },
		Mixins = new Type[] { typeof(Mixins.Content), typeof(Mixins.Meta), typeof(Mixins.UmbracoProperties) })]
	public partial class ContentPage : FestivalStarterKit
	{
		#region ctor

		public ContentPage() { }
		public ContentPage(int nodeId) : base(nodeId) { }

		#endregion
	}
}
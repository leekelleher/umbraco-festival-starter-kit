using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "NewsListing", IconUrl = "folder.gif",
		Alias = "NewsListing",
		AllowedTemplates = new string[] { "NewsListing" },
		AllowedChildNodeTypes = new Type[] { typeof(NewsPage) },
		Mixins = new Type[] { typeof(Mixins.Content), typeof(Mixins.Meta), typeof(Mixins.UmbracoProperties) })]
	public partial class NewsListing : FestivalStarterKit
	{
		#region ctor

		public NewsListing() { }
		public NewsListing(int nodeId) : base(nodeId) { }

		#endregion
	}
}
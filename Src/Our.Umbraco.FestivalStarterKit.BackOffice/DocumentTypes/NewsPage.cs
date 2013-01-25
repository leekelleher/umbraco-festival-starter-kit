using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "NewsPage", IconUrl = "folder.gif",
		Alias = "NewsPage",
		AllowedTemplates = new string[] { "NewsPage" },
		AllowedChildNodeTypes = new Type[] { })]
	public partial class NewsPage : FestivalStarterKit
	{
		public NewsPage() { }
		public NewsPage(int nodeId) : base(nodeId) { }
	}
}
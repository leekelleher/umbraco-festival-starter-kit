using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "SessionPage", IconUrl = "folder.gif",
		Alias = "SessionPage",
		AllowedTemplates = new string[] { "SessionPage" },
		AllowedChildNodeTypes = new Type[] { })]
	public partial class SessionPage : FestivalStarterKit
	{
		public SessionPage() { }
		public SessionPage(int nodeId) : base(nodeId) { }
	}
}
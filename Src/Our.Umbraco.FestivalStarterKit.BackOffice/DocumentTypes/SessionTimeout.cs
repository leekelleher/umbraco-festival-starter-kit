using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "SessionTimeout", IconUrl = "folder.gif",
		Alias = "SessionTimeout",
		AllowedTemplates = new string[] { "RedirectToParent" },
		AllowedChildNodeTypes = new Type[] { })]
	public partial class SessionTimeout : FestivalStarterKit
	{
		public SessionTimeout() { }
		public SessionTimeout(int nodeId) : base(nodeId) { }
	}
}
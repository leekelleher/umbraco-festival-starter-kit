using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "SessionTimeout", IconUrl = "folder.gif",
		Alias = "SessionTimeout",
		AllowedTemplates = new string[] { },
		AllowedChildNodeTypes = new Type[] { },
		Mixins = new Type[] { typeof(Mixins.Content) })]
	public partial class SessionTimeout : FestivalStarterKit
	{
		public SessionTimeout() { }
		public SessionTimeout(int nodeId) : base(nodeId) { }
	}
}
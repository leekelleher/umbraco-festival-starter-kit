using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "SessionTimeslot", IconUrl = "folder.gif",
		Alias = "SessionTimeslot",
		AllowedTemplates = new string[] { },
		AllowedChildNodeTypes = new Type[] { typeof(SessionPage), typeof(SessionTimeout) })]
	public partial class SessionTimeslot : FestivalStarterKit
	{
		public SessionTimeslot() { }
		public SessionTimeslot(int nodeId) : base(nodeId) { }
	}
}
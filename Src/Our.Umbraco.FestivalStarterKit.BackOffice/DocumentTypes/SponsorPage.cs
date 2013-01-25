using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "SponsorPage", IconUrl = "folder.gif",
		Alias = "SponsorPage",
		AllowedTemplates = new string[] { "SponsorPage" },
		AllowedChildNodeTypes = new Type[] { })]
	public partial class SponsorPage : FestivalStarterKit
	{
		public SponsorPage() { }
		public SponsorPage(int nodeId) : base(nodeId) { }
	}
}
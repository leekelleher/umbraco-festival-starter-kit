using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "FestivalStarterKit", IconUrl = "folder.gif",
		Alias = "FestivalStarterKit",
		AllowedTemplates = new string[] { },
		AllowedChildNodeTypes = new Type[] { })]
	public partial class FestivalStarterKit : DocumentTypeBase
	{
		public FestivalStarterKit() { }
		public FestivalStarterKit(int nodeId) : base(nodeId) { }
	}
}
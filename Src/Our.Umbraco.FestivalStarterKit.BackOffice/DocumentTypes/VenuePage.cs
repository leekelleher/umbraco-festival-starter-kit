using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "VenuePage", IconUrl = "folder.gif",
		Alias = "VenuePage",
		AllowedTemplates = new string[] { "VenuePage" },
		AllowedChildNodeTypes = new Type[] { },
		Mixins = new Type[] { typeof(Mixins.Content), typeof(Mixins.Meta), typeof(Mixins.UmbracoProperties) })]
	public partial class VenuePage : FestivalStarterKit
	{
		#region ctor

		public VenuePage() { }
		public VenuePage(int nodeId) : base(nodeId) { }

		#endregion
	}
}
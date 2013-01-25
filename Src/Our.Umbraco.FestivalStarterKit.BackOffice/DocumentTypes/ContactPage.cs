using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "ContactPage", IconUrl = "folder.gif",
		Alias = "ContactPage",
		AllowedTemplates = new string[] { "ContactPage" },
		AllowedChildNodeTypes = new Type[] { },
		Mixins = new Type[] { typeof(Mixins.Content), typeof(Mixins.Meta), typeof(Mixins.UmbracoProperties) })]
	public partial class ContactPage : FestivalStarterKit
	{
		#region ctor

		public ContactPage() { }
		public ContactPage(int nodeId) : base(nodeId) { }

		#endregion
	}
}
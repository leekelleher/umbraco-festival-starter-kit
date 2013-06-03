using System;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "SessionListing", IconUrl = "folder.gif",
		Alias = "SessionListing",
		AllowedTemplates = new[] { "SessionListing" },
		AllowedChildNodeTypes = new[] { typeof(SessionTimeslot) },
        Mixins = new[] { typeof(Mixins.Alert) ,typeof(Mixins.Content), typeof(Mixins.Meta), typeof(Mixins.UmbracoProperties) })]
	public partial class SessionListing : FestivalStarterKit
	{
		#region ctor

		public SessionListing() { }
		public SessionListing(int nodeId) : base(nodeId) { }

		#endregion
	}
}
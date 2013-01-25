using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "SponsorListing", IconUrl = "folder.gif",
		Alias = "SponsorListing",
		AllowedTemplates = new string[] { "SponsorListing" },
		AllowedChildNodeTypes = new Type[] { typeof(SponsorPage) },
		Mixins = new Type[] { typeof(Mixins.Content), typeof(Mixins.Meta), typeof(Mixins.UmbracoProperties) })]
	public partial class SponsorListing : FestivalStarterKit
	{
		#region ctor

		public SponsorListing() { }
		public SponsorListing(int nodeId) : base(nodeId) { }

		#endregion
	}
}
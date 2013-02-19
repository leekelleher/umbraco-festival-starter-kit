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
		AllowedChildNodeTypes = new Type[] { },
		Mixins = new Type[] { typeof(Mixins.Content), typeof(Mixins.Meta), typeof(Mixins.UmbracoProperties) })]
	public partial class SponsorPage : FestivalStarterKit
	{
		#region ctor

		public SponsorPage() { }
		public SponsorPage(int nodeId) : base(nodeId) { }

		#endregion

		[DocumentTypeProperty(UmbracoPropertyType.Upload, Name = "Sponsor Logo", Description = "", Tab = Tabs.Content, Mandatory = true)]
		public string SponsorLogo { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Sponsor Link", Description = "The URL to the sponsor's website.", Tab = Tabs.Content, Mandatory = true)]
		public string SponsorLink { get; set; }
	}
}
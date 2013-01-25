using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "SpeakerListing", IconUrl = "folder.gif",
		Alias = "SpeakerListing",
		AllowedTemplates = new string[] { "SpeakerListing" },
		AllowedChildNodeTypes = new Type[] { typeof(SpeakerPage) },
		Mixins = new Type[] { typeof(Mixins.Content), typeof(Mixins.Meta), typeof(Mixins.UmbracoProperties) })]
	public partial class SpeakerListing : FestivalStarterKit
	{
		#region ctor

		public SpeakerListing() { }
		public SpeakerListing(int nodeId) : base(nodeId) { }

		#endregion
	}
}
using System;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "Homepage", IconUrl = "folder.gif",
		Alias = "Homepage",
		AllowedTemplates = new[] { "Homepage" },
		AllowedChildNodeTypes = new[] { typeof(SessionListing), typeof(VenuePage), typeof(NewsListing), typeof(SponsorListing), typeof(ContactPage), typeof(ContentPage), typeof(SpeakerListing), typeof(FAQListing), },
		Mixins = new[] { typeof(Mixins.Meta), typeof(Mixins.Webmaster) })]
	public partial class Homepage : FestivalStarterKit
	{
		#region ctor

		public Homepage() { }
		public Homepage(int nodeId) : base(nodeId) { }

		#endregion

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Festival Title", Description = "", Tab = Tabs.Content, Mandatory = true)]
		public string FestivalTitle { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.TextboxMultiple, Name = "Festival Description", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public string FestivalDescription { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.Upload, Name = "Festival Logo", Description = "", Tab = Tabs.Content, Mandatory = true)]
		public string FestivalLogo { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.DatePickerWithTime, Name = "Festival Start Date", Description = "", Tab = Tabs.Content, Mandatory = true)]
		public DateTime FestivalStartDate { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Festival Twitter Username", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public string FestivalTwitterUsername { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Festival Ticket Url", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public string FestivalTicketUrl { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.Other, OtherTypeName = "Style Picker", Name = "Style Picker", Description = "These are the default themes from bootswatch.com", Tab = Tabs.Settings, Mandatory = false)]
		public string StylePicker { get; set; }
	}
}
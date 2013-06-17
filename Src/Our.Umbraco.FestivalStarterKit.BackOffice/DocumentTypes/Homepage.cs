using System;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "Homepage", IconUrl = "folder.gif",
		Alias = "Homepage",
		AllowedTemplates = new[] { "Homepage" },
		AllowedChildNodeTypes = new[] { typeof(SessionListing), typeof(VenuePage), typeof(NewsListing), typeof(SponsorListing), typeof(ContactPage), typeof(ContentPage), typeof(SpeakerListing), typeof(FaqListing), })]
	public partial class Homepage : FestivalStarterKit
	{
		#region ctor

		public Homepage() { }
		public Homepage(int nodeId) : base(nodeId) { }

		#endregion

		#region Content

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Festival Title", Description = "", Tab = Tabs.Content, Mandatory = true)]
		public string FestivalTitle { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.TextboxMultiple, Name = "Festival Description", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public string FestivalDescription { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.Upload, Name = "Festival Logo", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public string FestivalLogo { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.DatePickerWithTime, Name = "Festival Start Date", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public DateTime FestivalStartDate { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Festival Twitter Username", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public string FestivalTwitterUsername { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Festival Ticket Url", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public string FestivalTicketUrl { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.Other, OtherTypeName = "Style Picker", Name = "Style Picker", Description = "These are alternative themes from bootswatch.com", Tab = Tabs.Content, Mandatory = false)]
		public string StylePicker { get; set; }

		#endregion

		#region Meta

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Meta Title", Description = "This field will override the &lt;title&gt; tag.", Tab = Tabs.Meta, Mandatory = false)]
		public string MetaTitle { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Meta Keywords", Description = "", Tab = Tabs.Meta, Mandatory = false)]
		public string MetaKeywords { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.TextboxMultiple, Name = "Meta Description", Description = "", Tab = Tabs.Meta, Mandatory = false)]
		public string MetaDescription { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.TrueFalse, Name = "Show in Main Navigation?", Description = "", Tab = Tabs.Meta, Mandatory = false)]
		public bool ShowMainNavigation { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.TrueFalse, Name = "Show in Footer Navigation?", Description = "", Tab = Tabs.Meta, Mandatory = false)]
		public bool ShowFooterNavigation { get; set; }

		#endregion

		#region Webmaster

		[DocumentTypeProperty(UmbracoPropertyType.TextboxMultiple, Name = "Verification Code", Description = "The verification code (typically used for Google Webmaster Tools) will be inserted into the &lt;head&gt; tag.", Tab = Tabs.Webmaster, Mandatory = false)]
		public string VerificationCode { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.TextboxMultiple, Name = "Analytics Code", Description = "The analytics code (typically used for Google Analytics) will be appened to the &lt;body&gt; tag.", Tab = Tabs.Webmaster, Mandatory = false)]
		public HtmlString AnalyticsCode { get; set; }

		#endregion
	}
}
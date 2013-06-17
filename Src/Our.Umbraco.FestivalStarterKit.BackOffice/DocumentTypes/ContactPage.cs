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
		AllowedChildNodeTypes = new Type[] { })]
	public partial class ContactPage : FestivalStarterKit
	{
		#region ctor

		public ContactPage() { }
		public ContactPage(int nodeId) : base(nodeId) { }

		#endregion

		#region Content

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Page Title", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public string PageTitle { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.RichtextEditor, Name = "Page Text", Description = "", Tab = Tabs.Content, Mandatory = false)]
		public HtmlString PageText { get; set; }

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

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Url Name", Description = "Change the URL of the content node.", Mandatory = false)]
		public string UmbracoUrlName { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.Textstring, Name = "Url Alias", Description = "Assign multiple URLs to this page, comma-separated.", Mandatory = false)]
		public string UmbracoUrlAlias { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.ContentPicker, Name = "Redirect", Description = "Select a content node to do a redirect; i.e. the page URL changes in the web-browser.", Mandatory = false)]
		public string UmbracoRedirect { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.ContentPicker, Name = "Internal Redirect", Description = "Select the content node to do an internal redirect; i.e. the page URL does not change.", Mandatory = false)]
		public string UmbracoInternalRedirectId { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.TrueFalse, Name = "Hide from Navigation", Description = "Set this page to be hidden from the navigation/sitemap.", Mandatory = false)]
		public string UmbracoNaviHide { get; set; }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes.Mixins
{
	public class UmbracoProperties
	{
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
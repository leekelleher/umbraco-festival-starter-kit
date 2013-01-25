using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes.Mixins
{
	public class Meta
	{
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

	}
}
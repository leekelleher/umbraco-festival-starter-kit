using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes.Mixins
{
	public class Webmaster
	{
		[DocumentTypeProperty(UmbracoPropertyType.TextboxMultiple, Name = "Verification Code", Description = "The verification code (typically used for Google Webmaster Tools) will be inserted into the &lt;head&gt; tag.", Tab = Tabs.Webmaster, Mandatory = false)]
		public string VerificationCode { get; set; }

		[DocumentTypeProperty(UmbracoPropertyType.TextboxMultiple, Name = "Analytics Code", Description = "The analytics code (typically used for Google Analytics) will be appened to the &lt;body&gt; tag.", Tab = Tabs.Webmaster, Mandatory = false)]
		public string AnalyticsCode { get; set; }
	}
}
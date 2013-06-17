using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice
{
	public enum Tabs
	{
		[TabName("Content")]
		Content = 10,

		[TabName("Social")]
		Social = 20,

		[TabName("Alert")]
		Alert = 40,

		[TabName("Webmaster")]
		Webmaster = 60,

		[TabName("Meta")]
		Meta = 80,
	}
}
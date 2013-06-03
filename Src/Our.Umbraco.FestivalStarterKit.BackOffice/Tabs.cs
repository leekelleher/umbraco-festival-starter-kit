using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice
{
	public enum Tabs
	{
		[TabName("Content")]
		Content = 10,

        [TabName("Alert")]
        Alert = 40,

        [TabName("Settings")]
        Settings = 50,

		[TabName("Webmaster")]
		Webmaster = 60,

		[TabName("Meta")]
		Meta = 80,
	}
}
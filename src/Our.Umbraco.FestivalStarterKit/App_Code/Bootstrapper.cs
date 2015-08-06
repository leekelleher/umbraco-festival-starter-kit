using Our.Umbraco.FestivalStarterKit.App_Code.UrlProviders;
using Umbraco.Core;
using Umbraco.Web.Routing;

namespace Our.Umbraco.FestivalStarterKit.App_Code
{
    public class Bootstrapper : ApplicationEventHandler
    {
        protected override void ApplicationStarting(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            UrlProviderResolver.Current.InsertTypeBefore<DefaultUrlProvider, SectionsUrlProvider>();
        }
    }
}
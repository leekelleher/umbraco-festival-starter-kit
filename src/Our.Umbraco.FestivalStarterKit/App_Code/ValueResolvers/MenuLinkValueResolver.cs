using Our.Umbraco.Ditto;
using Our.Umbraco.FestivalStarterKit.App_Code.Models;
using System.Linq;
using Umbraco.Web;

namespace Our.Umbraco.FestivalStarterKit.App_Code.ValueResolvers
{
    public class MenuLinkValueResolver : DittoValueResolver
    {
        public override object ResolveValue()
        {
            if (Content == null)
                return Enumerable.Empty<MenuLink>();

            return Content
                .AncestorOrSelf(1)
                .Children
                .Where(x => x.IsVisible() && x.DocumentTypeAlias.EndsWith("Section"))
                .As<MenuLink>();
        }
    }
}
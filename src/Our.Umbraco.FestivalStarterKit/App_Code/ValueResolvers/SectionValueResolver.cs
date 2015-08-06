using Our.Umbraco.Ditto;
using Our.Umbraco.FestivalStarterKit.App_Code.Models;
using System.Linq;
using Umbraco.Web;

namespace Our.Umbraco.FestivalStarterKit.App_Code.ValueResolvers
{
    public class SectionValueResolver : DittoValueResolver
    {
        public override object ResolveValue()
        {
            if (Content == null)
                return Enumerable.Empty<MenuLink>();

            return Content
                .AncestorsOrSelf(1)
                .First()
                .Children
                .Where(x => x.IsVisible() && x.DocumentTypeAlias.EndsWith("Section"))
                .As<Section>();
        }
    }
}
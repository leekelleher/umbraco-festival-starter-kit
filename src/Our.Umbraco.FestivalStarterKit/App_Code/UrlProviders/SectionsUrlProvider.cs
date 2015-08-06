using System;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Web;
using Umbraco.Web.Routing;

namespace Our.Umbraco.FestivalStarterKit.App_Code.UrlProviders
{
    public class SectionsUrlProvider : IUrlProvider
    {
        public IEnumerable<string> GetOtherUrls(UmbracoContext umbracoContext, int id, Uri current)
        {
            return Enumerable.Empty<string>();
        }

        public string GetUrl(UmbracoContext umbracoContext, int id, Uri current, UrlProviderMode mode)
        {
            var content = umbracoContext.ContentCache.GetById(id);
            if (content != null && content.DocumentTypeAlias.EndsWith("Section"))
            {
                return string.Concat("#", content.UrlName);
            }

            return null;
        }
    }
}
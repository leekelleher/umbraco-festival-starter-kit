using Our.Umbraco.Ditto;
using Our.Umbraco.FestivalStarterKit.App_Code.ValueResolvers;
using System.Collections.Generic;
using Umbraco.Core.Models;

namespace Our.Umbraco.FestivalStarterKit.App_Code.Models
{
    public class Navigation
    {
        [DittoValueResolver(typeof(MenuLinkValueResolver))]
        public IEnumerable<MenuLink> MenuItems { get; set; }
    }
}
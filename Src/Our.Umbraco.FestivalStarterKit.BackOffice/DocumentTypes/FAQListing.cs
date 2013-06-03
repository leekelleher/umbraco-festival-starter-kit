using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
    [DocumentType(Name="FAQListing", IconUrl="folder.gif", 
        Alias="FAQListing",
        AllowedTemplates= new string[] {"FAQListing"},
        AllowedChildNodeTypes = new Type[] {typeof(FAQ)},
        Mixins = new Type[] { typeof(Mixins.Alert), typeof(Mixins.Content), typeof(Mixins.Meta), typeof(Mixins.UmbracoProperties) })]
    public partial class FAQListing : FestivalStarterKit
    {
        public FAQListing () {}
        public FAQListing (int nodeId) : base(nodeId){}
        

    }
}
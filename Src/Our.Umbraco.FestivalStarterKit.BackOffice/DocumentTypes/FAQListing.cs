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
        AllowedChildNodeTypes = new Type[] {typeof(FAQ)})]
    public partial class FAQListing : FestivalStarterKit
    {
        public FAQListing () {}
        public FAQListing (int nodeId) : base(nodeId){}
        
        [DocumentTypeProperty(UmbracoPropertyType.TrueFalse,  Name = "Show in Main Navigation?", Description = "", Tab = "Meta", Mandatory = false )]
        public bool ShowMainNavigation { get; set; }
    }
}
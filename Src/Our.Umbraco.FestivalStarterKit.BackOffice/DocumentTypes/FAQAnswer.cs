using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
    [DocumentType(Name="FAQAnswer", IconUrl="folder.gif", 
        Alias="FAQAnswer",
        AllowedTemplates= new string[] {},
        AllowedChildNodeTypes = new Type[] {})]
    public partial class FAQAnswer : FestivalStarterKit
    {
        public FAQAnswer () {}
        public FAQAnswer (int nodeId) : base(nodeId){}
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
    [DocumentType(Name="FAQ", IconUrl="folder.gif", 
        Alias="FAQ",
        AllowedTemplates= new string[] {},
        AllowedChildNodeTypes = new Type[] {typeof(FAQAnswer)})]
    public partial class FAQ : FestivalStarterKit
    {
        public FAQ () {}
        public FAQ (int nodeId) : base(nodeId){}
        
    }
}
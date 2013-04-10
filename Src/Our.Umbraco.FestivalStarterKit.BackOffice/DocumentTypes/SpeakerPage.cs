using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DocumentTypes
{
	[DocumentType(Name = "SpeakerPage", IconUrl = "folder.gif",
		Alias = "SpeakerPage",
		AllowedTemplates = new string[] { "SpeakerPage" },
		AllowedChildNodeTypes = new Type[] { })]
	public partial class SpeakerPage : FestivalStarterKit
	{
		public SpeakerPage() { }
		public SpeakerPage(int nodeId) : base(nodeId) { }


        //[DocumentTypeProperty(UmbracoPropertyType.Upload, Name = "Speaker Photo", Description = "", Tab = Tabs.Content, Mandatory = false)]
        //public string speakerPhoto { get; set; }

	}
}
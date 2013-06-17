using ServiceStack.Text;
using umbraco.cms.businesslogic.datatype;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DataTypes
{
	[DataType(Name = SpeakerPicker.Name, UniqueId = SpeakerPicker.Guid, RenderControlGuid = umbraco.editorControls.DataTypeGuids.XPathDropDownListId, DatabaseDataType = DBTypes.Ntext)]
	public partial class SpeakerPicker : DataTypeBase
	{
		public const string Name = "Speaker Picker";
		public const string Guid = "4E0E46E7-D64B-45EA-9644-7671729218F1";

		public override DataTypePrevalue[] Prevalues
		{
			get
			{
				var options = new
				{
					Type = "c66ba18e-eaf3-4cff-8a22-41b16d66a972",
					XPath = "//SpeakerPage",
					UseIds = true,
					UmbracoObjectType = 3
				};

				return new DataTypePrevalue[]
				{
					new DataTypePrevalue(string.Empty, JsonSerializer.SerializeToString(options))
				};
			}
		}
	}
}
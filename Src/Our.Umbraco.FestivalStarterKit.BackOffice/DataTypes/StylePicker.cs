using System.Linq;
using umbraco.cms.businesslogic.datatype;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DataTypes
{
	[DataType(Name = StylePicker.Name, UniqueId = StylePicker.Guid, RenderControlGuid = "a74ea9c9-8e18-4d2a-8cf6-73c6206c5da6", DatabaseDataType = DBTypes.Ntext)]
	public partial class StylePicker : DataTypeBase
	{
		public const string Name = "Style Picker";
		public const string Guid = "FE079CB7-24A9-44DC-BA4A-39091C8404CC";

		public override DataTypePrevalue[] Prevalues
		{
			get
			{
				var styles = new[] { "amelia", "cerulean", "cosmo", "cyborg", "journal", "readable", "simplex", "slate", "spacelab", "spruce", "superhero", "united" };
				return styles.Select(x => new DataTypePrevalue(string.Empty, x)).ToArray();
			}
		}
	}
}
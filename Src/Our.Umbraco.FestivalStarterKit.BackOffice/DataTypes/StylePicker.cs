using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using umbraco.cms.businesslogic.datatype;
using Vega.USiteBuilder;

namespace Our.Umbraco.FestivalStarterKit.BackOffice.DataTypes
{
    [DataType(Name = "Style Picker", UniqueId = "fe079cb7-24a9-44dc-ba4a-39091c8404cc", RenderControlGuid = "a74ea9c9-8e18-4d2a-8cf6-73c6206c5da6", DatabaseDataType = DBTypes.Ntext)]
    public partial class StylePicker : DataTypeBase
    {
        public override DataTypePrevalue[] Prevalues
        {
            get
            {
                return new DataTypePrevalue[]
                {
                    new DataTypePrevalue("", "amelia"),
new DataTypePrevalue("", "cerulean"),
new DataTypePrevalue("", "cosmo"),
new DataTypePrevalue("", "cyborg"),
new DataTypePrevalue("", "journal"),
new DataTypePrevalue("", "readable"),
new DataTypePrevalue("", "simplex"),
new DataTypePrevalue("", "slate"),
new DataTypePrevalue("", "spacelab"),
new DataTypePrevalue("", "spruce"),
new DataTypePrevalue("", "superhero"),
new DataTypePrevalue("", "united")
                };
            }
        }
    }
}
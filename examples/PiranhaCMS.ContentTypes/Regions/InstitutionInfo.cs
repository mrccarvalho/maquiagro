using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    public class InstitutionInfo
    {
        [Field(Title = "Logotipo")]
        public ImageField Logotipo { get; set; }

        [Field(Title = "Nome")]
        public StringField Name { get; set; }




        [Field(Title = "External link")]
        public StringField ExternalUrl { get; set; }

        [Field(Title = "Link text")]
        public StringField LinkText { get; set; }

        [Field(Title = "Open link in new window", Options = FieldOption.HalfWidth)]

        public CheckBoxField OpenInNewWindow { get; set; }

    }
}
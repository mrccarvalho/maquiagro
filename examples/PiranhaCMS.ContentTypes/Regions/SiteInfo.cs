using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    public class SiteInfo
    {
        [Field(Title = "Site Title", Options = FieldOption.HalfWidth)]
        public StringField SiteTitle { get; set; }

        [Field(Title = "Tag Line", Options = FieldOption.HalfWidth)]
        public StringField Tagline { get; set; }

        [Field(Title = "Site Logo")]
        public ImageField SiteLogo { get; set; }
    }
}
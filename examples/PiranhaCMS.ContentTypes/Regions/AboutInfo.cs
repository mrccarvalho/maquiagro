using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    public class AboutInfo
    {
        [Field(Title = "Imagem")]
        public ImageField AboutImage { get; set; }

        [Field(Title = "Título")]
        public StringField Title { get; set; }

                [Field(Title = "SubTítulo")]
        public StringField SubTitle { get; set; }



   

    }
}
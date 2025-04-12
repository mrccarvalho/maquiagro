using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    public class Faq
    {
        [Field(Title = "Título")]
        public StringField Title { get; set; }

        [Field(Title = "Descrição")]
        public HtmlField Description { get; set; }
    }
}
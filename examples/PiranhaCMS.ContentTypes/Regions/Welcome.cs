using System.ComponentModel.DataAnnotations;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    public class Welcome
    {

        [Field(Title = "Imagem")]
        public ImageField Imagem { get; set; }

        [Field(Title = "Topicos")]
        public HtmlField Topics { get; set; }

        [Field(Title = "Descrição")]
        public HtmlField Description { get; set; }

        [Field(Title = "Desde")]
        public StringField Since { get; set; }

        [Field(Title = "Ano Fundação")]
        public StringField Year { get; set; }

        [Field(Title = "Link Página")]
        public PageField PageLink { get; set; }

        [Field(Title = "CEO / Fundador")]
        public StringField FounderText { get; set; }

        [Field(Title = "Nome CEO / Fundador")]
        public StringField Founder { get; set; }

    }


}
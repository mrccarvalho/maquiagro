using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using PiranhaCMS.ContentTypes.Pages.Base;
using System.ComponentModel.DataAnnotations;

namespace PiranhaCMS.ContentTypes.Pages
{
    [PostType(Title = "Notícia")]
    [ContentTypeRoute(Title = "Default", Route = "/noticiaitem")]
    public class NewsPost : Post<NewsPost>, IPage
    {
        public class NewsInfo
        {
            [Field(Title = "Título")]
            public StringField Title { get; set; }

            [Field(Title = "Resumo")]
            public HtmlField Description { get; set; }
        }

        /// <summary>
        /// Gets/sets the Heading.
        /// </summary>
        [Region(Title = "Cabeçalho da Página", Display = RegionDisplayMode.Content)]
        public PageHeaderRegion PageHeader { get; set; }

        public class PageHeaderRegion
        {
            [Field(Title = "Cabeçalho", Placeholder = "Cabeçalho")]

            [StringLength(15, ErrorMessage = "Cabeçalho: maximo de caracteres é 15!")]
            public StringField Heading { get; set; }

            [Field(Title = "Imagem de Topo")]
            //[Required(ErrorMessage = "Top image: required!")]
            public ImageField TopImage { get; set; }
        }

        [Region (Title = "Detalhes da Notícia")]
        public NewsInfo NewsInfos { get; set; }

    }
}
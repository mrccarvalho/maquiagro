using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using PiranhaCMS.ContentTypes.Pages.Base;
using System.ComponentModel.DataAnnotations;

namespace PiranhaCMS.ContentTypes.Pages
{
    [PostType(Title = "Serviço")]
    [ContentTypeRoute(Title = "Default", Route = "/servicoitem")]
    public class ServicePost : Post<ServicePost>, IPage
    {

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

   

    }
}
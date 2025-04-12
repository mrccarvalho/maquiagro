using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using PiranhaCMS.ContentTypes.Pages.Base;
using PiranhaCMS.ContentTypes.Regions;
using System.ComponentModel.DataAnnotations;

namespace PiranhaCMS.ContentTypes.Pages
{
    [PostType(Title = "Rachadores de Lenha")]
    [ContentTypeRoute(Title = "Default", Route = "/rachadoritem")]
    public class RachadorPost : Post<RachadorPost>, IPage
    {
        /// <summary>
        /// Gets/sets the Cabeçalho.
        /// </summary>
        [Region(Title = "Cabeçalho da Página", Display = RegionDisplayMode.Content)]
       
        public PageHeaderRegion PageHeader { get; set; }


        

         public class PageHeaderRegion
        {
            [Field(Title = "Cabeçalho", Placeholder = "Cabeçalho")]

            [StringLength(15, ErrorMessage = "Cabeçalho: maximo de characteres é 15!")]
            public StringField Cabeçalho { get; set; }

            [Field(Title = "imagem Topo")]
            [Required(ErrorMessage = "imagem Topo: obrigatório!")]
            public ImageField TopImage { get; set; }
        }
       
       [Region (Title = "Dados Gerais da Máquina")]
        public ProductInfo ProductInfo { get; set; }

        [Region (Title = "Especificações")]
        public ProductSpecification ProductSpecification { get; set; }


          [Region (Title = "Imagens da Máquina", ListTitle = "BigImage")]
        public IList<ProductImage> MachineImages { get; set; }

      //[Region(Title = "Botão Ler Mais (fonte da notícia)")]
        //public LinkButton ReadMoreBtn { get; set; }
    }
}
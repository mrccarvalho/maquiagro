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
    [PostType(Title = "Atrelados")]
    [ContentTypeRoute(Title = "Default", Route = "/atreladoitem")]
    public class AtreladosPost : Post<AtreladosPost>, IPage
    {
        /// <summary>
        /// Gets/sets the Heading.
        /// </summary>
        [Region(Title = "Cabeçalho da Página", Display = RegionDisplayMode.Content)]
        public PageHeaderRegion PageHeader { get; set; }


         public class PageHeaderRegion
        {
            [Field(Title = "Heading", Placeholder = "Heading")]

            [StringLength(15, ErrorMessage = "Heading: maximum allowed characters is 15!")]
            public StringField Heading { get; set; }

            [Field(Title = "Top image")]
            //[Required(ErrorMessage = "Top image: required!")]
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
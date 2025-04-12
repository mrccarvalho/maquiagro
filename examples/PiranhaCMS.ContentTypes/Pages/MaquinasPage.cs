using PiranhaCMS.ContentTypes.Pages.Base;
using PiranhaCMS.ContentTypes.Regions;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PiranhaCMS.Validators.Attributes;
using PiranhaCMS.ContentTypes.Blocks;

namespace PiranhaCMS.ContentTypes.Pages
{
    [PageType(Title = "Máquinas (Página Inicial)", UsePrimaryImage = false, UseExcerpt = false, UseBlocks = false)]
    [ContentTypeRoute(Title = "Default", Route = "/maquinaspage")]
        //[BlockItemType(typeof(WelcomeBlock))]


    public class MaquinasPage : Page<MaquinasPage>, IPage
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
    }
}

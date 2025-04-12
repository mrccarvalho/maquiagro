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
    [PageType(Title = "Generic Page", UsePrimaryImage = false, UseExcerpt = false, UseBlocks = true)]
    [ContentTypeRoute(Title = "Default", Route = "/standardpage")]
        [BlockItemType(typeof(WelcomeBlock))]
    [BlockItemType(typeof(FaqBlock))]
    [BlockItemType(typeof(SkillsBlock))]
    //[BlockItemType(typeof(CounterBlockGroup))]
    [BlockItemType(typeof(CounterBlock))]
        [BlockItemType(typeof(Counter2BlockGroup))]
    [BlockItemType(typeof(Counter2Block))]
       [BlockItemType(typeof(AproachBlock))]

    public class StandardPage : Page<StandardPage>, IPage
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

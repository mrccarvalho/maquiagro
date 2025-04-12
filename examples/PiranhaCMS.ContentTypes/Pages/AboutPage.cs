using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using PiranhaCMS.ContentTypes.Pages.Base;
using PiranhaCMS.ContentTypes.Regions;
using PiranhaCMS.Validators.Attributes;


namespace PiranhaCMS.ContentTypes.Pages
{
    [PageType(Title = "Sobre", UsePrimaryImage = false, UseExcerpt = false, UseBlocks = true)]
    [ContentTypeRoute(Title = "Default", Route = $"/{nameof(AboutPage)}")]
    //[AllowedPageTypes(Availability.None)]
    [BlockItemType(typeof(Blocks.AboutBlock))]
    [BlockItemType(typeof(Blocks.WelcomeBlock))]
    [BlockItemType(typeof(Blocks.FaqBlock))]
    [BlockItemType(typeof(Blocks.SkillsBlock))]
    //[BlockItemType(typeof(CounterBlockGroup))]
    [BlockItemType(typeof(Blocks.CounterBlock))]
    [BlockItemType(typeof(Blocks.Counter2BlockGroup))]
    [BlockItemType(typeof(Blocks.Counter2Block))]
    [BlockItemType(typeof(Blocks.AproachBlock))]
    public class AboutPage : Page<AboutPage>, IPage
    {


       // [Region(Title = "Sobre", Description = "Sobre")]
       // public AboutInfo aboutInfo { get; set; }

        /// <summary>
        /// Gets/sets the Heading.
        /// </summary>
        [Region(Title = "Cabeçalho da Página", Display = RegionDisplayMode.Content)]
        public PageHeaderRegion PageHeader { get; set; }



        public class PageHeaderRegion
        {
            [Field(Title = "Heading", Placeholder = "Heading")]

            //[Required(ErrorMessage = "Heading: required!")]
            [StringLength(200, ErrorMessage = "Heading: maximum allowed characters is 200!")]
            public StringField Heading { get; set; }

            [Field(Title = "Top image")]

            //[Required(ErrorMessage = "Top image: required!")]
            public ImageField TopImage { get; set; }
        }




    }
}

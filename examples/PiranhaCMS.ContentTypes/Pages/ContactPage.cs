using PiranhaCMS.ContentTypes.Pages.Base;
using PiranhaCMS.ContentTypes.Regions;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PiranhaCMS.Validators.Attributes;


namespace PiranhaCMS.ContentTypes.Pages
{
    [PageType(Title = "Contactos", UsePrimaryImage = false, UseExcerpt = false, UseBlocks = true)]
    [ContentTypeRoute(Title = "Default", Route = "/contactospage")]
    //[AllowedPageTypes(Availability.None)]
     [BlockItemType(typeof(Blocks.ContactBlock))]
    public class ContactPage : Page<ContactPage>, IPage
    {

        /// <summary>
        /// Gets/sets the Heading.
        /// </summary>
        [Region(Title = "Cabeçalho da Página", Display = RegionDisplayMode.Content)]
        public PageHeaderRegion PageHeader { get; set; }

        public class PageHeaderRegion
        {
            [Field(Title = "Heading", Placeholder = "Heading")]

            [Required(ErrorMessage = "Heading: required!")]
            [StringLength(200, ErrorMessage = "Heading: maximum allowed characters is 200!")]
            public StringField Heading { get; set; }

            [Field(Title = "Top image")]

            [Required(ErrorMessage = "Top image: required!")]
            public ImageField TopImage { get; set; }
        }




    }
}

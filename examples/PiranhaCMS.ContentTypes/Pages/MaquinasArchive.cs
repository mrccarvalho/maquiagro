using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;
using Piranha.Extend.Fields;
using PiranhaCMS.ContentTypes.Pages.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PiranhaCMS.Validators.Attributes;

namespace PiranhaCMS.ContentTypes.Pages
{
    [PageType(Title = "Máquinas", UseBlocks = true, IsArchive = true)]
    [PageTypeArchiveItem(typeof(CapinadeirasPost))]
    [PageTypeArchiveItem(typeof(AtreladosPost))]
     [PageTypeArchiveItem(typeof(RachadorPost))]
    [PageTypeArchiveItem(typeof(MaquinasArchive))]
    [ContentTypeRoute(Title = "Default", Route = "/maquinas")]
    [ContentTypeRoute(Title = "Capinadeiras", Route = "/capinadeiras")]
     [ContentTypeRoute(Title = "Atrelados", Route = "/atrelados")]
        [ContentTypeRoute(Title = "Rachadores", Route = "/rachadores")]
        //[AllowedPageTypes(new[]
   // {
        //typeof(StandardPage)
   // })]
    public class MaquinasArchive: Page<MaquinasArchive>, IPage
    {

        /// <summary>
        /// Gets/sets the Heading.
        /// </summary>
        [Region(Title = "Cabeçalho da Página", Display = RegionDisplayMode.Content)]
        public PageHeaderRegion PageHeader { get; set; }
         /// <summary>
        /// View model property for storing the current archive items.
        /// </summary>
        //public PostArchive<NewsPost> Archive { get; set; }
        public PostArchive<PostInfo> Archive { get; set; }

        

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
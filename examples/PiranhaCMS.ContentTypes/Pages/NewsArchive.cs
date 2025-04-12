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
using PiranhaCMS.ContentTypes.Blocks;

namespace PiranhaCMS.ContentTypes.Pages
{
    [PageType(Title = "Notícias", UseBlocks = true, IsArchive = true)]
    [PageTypeArchiveItem(typeof(NewsPost))]
    [ContentTypeRoute(Title = "Default", Route = "/noticias")]
    [ContentTypeRoute(Title = "DefaultAlt", Route = "/noticias-alt")]
    [ContentTypeRoute(Title = "DefaultAlt2", Route = "/noticias-alt-2")]
        [BlockItemType(typeof(NewsBlock))]
    public class NewsArchive: Page<NewsArchive>, IPage
    {

         /// <summary>
        /// View model property for storing the current archive items.
        /// </summary>
        //public PostArchive<NewsPost> Archive { get; set; }
        public PostArchive<NewsPost> Archive { get; set; }

         public PageHeaderRegion PageHeader { get; set; }
        

         public class PageHeaderRegion
        {
            [Field(Title = "Cabeçalho", Placeholder = "Cabeçalho")]

            [StringLength(15, ErrorMessage = "Cabeçalho: maximo de caracteres é 15!")]
            public StringField Heading { get; set; }

            [Field(Title = "Top image")]
            //[Required(ErrorMessage = "Top image: required!")]
            public ImageField TopImage { get; set; }
        }

    
    }
}
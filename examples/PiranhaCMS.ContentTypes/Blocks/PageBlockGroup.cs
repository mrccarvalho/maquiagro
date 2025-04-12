using PiranhaCMS.ContentTypes.Blocks.Base;
using PiranhaCMS.ContentTypes.Constants;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using Piranha.Extend.Blocks;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PiranhaCMS.ContentTypes.Blocks
{
    [BlockGroupType(
        Name = "Block de Páginas", 
        Display = BlockDisplayMode.Horizontal, 
        Category = Global.TeasersCategory,
        Icon = "fas fa-list")]
    [BlockItemType(Type = typeof(PageBlock))]
    public class PageBlockGroup : BlockGroupBase
    { 
                
        [Field]

        public PageField pagina { get; set; }
    }
}

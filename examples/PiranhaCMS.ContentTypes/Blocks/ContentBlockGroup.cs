

using Piranha.Extend.Blocks;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System.ComponentModel.DataAnnotations;
using System.Text;
using PiranhaCMS.ContentTypes.Blocks.Base;
using PiranhaCMS.ContentTypes.Constants;

namespace PiranhaCMS.ContentTypes.Blocks
{
    [BlockGroupType(
        Name = "Content block Group", IsGeneric = true,
        //Display = BlockDisplayMode.Vertical, 
        Category = Global.TeasersCategory)]
    [BlockItemType(Type = typeof(ContentBlock))]
    public class ContentBlockGroup : BlockGroupBase
    {
      
                    [Field(Title = "Heading")]
        public StringField Heading { get; set; }
       

    }
}

using PiranhaCMS.ContentTypes.Blocks.Base;
using PiranhaCMS.ContentTypes.Constants;
using PiranhaCMS.Models;
using Piranha.Extend;
using Piranha.Extend.Fields;

namespace PiranhaCMS.ContentTypes.Blocks
{
    [BlockType(Name = "FAQ", Icon = "fas fa-sharp fa-solid fa-x", Category = Global.OutrosCategory)]

    public class _FaqBlock : BlockBase
    {

        [Field(Title = "Título")]
        public StringField Title { get; set; }

        [Field(Title = "Descrição")]
        public HtmlField Description { get; set; }

        //[Field(Title = "Descrição")]
        //public HtmlField Description { get; set; }

    }


}

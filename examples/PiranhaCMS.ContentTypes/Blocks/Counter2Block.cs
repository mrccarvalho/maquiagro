

using PiranhaCMS.ContentTypes.Blocks.Base;
using PiranhaCMS.ContentTypes.Constants;
using Piranha.Extend;
using Piranha.Extend.Fields;
using PiranhaCMS.Models;
namespace PiranhaCMS.ContentTypes.Blocks
{
    [BlockType(Name = "Counter 2", Icon = "fas fa-sharp fa-solid fa-x", Category = Global.OutrosCategory)]

    public class Counter2Block : BlockBase
    {

        [Field(Title = "Título")]
        public StringField Title { get; set; }

        [Field(Title = "Icon")]
        public StringField Icon { get; set; }

    }


}

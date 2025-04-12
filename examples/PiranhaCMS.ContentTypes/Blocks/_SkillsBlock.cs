using PiranhaCMS.ContentTypes.Blocks.Base;
using PiranhaCMS.ContentTypes.Constants;
using Piranha.Extend;
using Piranha.Extend.Fields;
using PiranhaCMS.Models;

namespace PiranhaCMS.ContentTypes.Blocks
{
    [BlockType(Name = "Skill", Icon = "fas fa-sharp fa-solid fa-x", Category = Global.OutrosCategory)]

    public class _SkillsBlock : BlockBase
    {

        [Field(Title = "Skill")]
        public StringField Skill { get; set; }

        [Field(Title = "Percentagem")]
        public StringField Percent { get; set; }

    }


}

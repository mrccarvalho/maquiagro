using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    public class SkillInfo
    {
        [Field(Title = "Skill")]
        public StringField Skill { get; set; }

        [Field(Title = "Percentagem")]
        public StringField Percent { get; set; }


    }
}
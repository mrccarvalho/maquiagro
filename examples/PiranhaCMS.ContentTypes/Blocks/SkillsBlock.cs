using System.Text;
using PiranhaCMS.ContentTypes.Blocks.Base;
using PiranhaCMS.ContentTypes.Constants;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Extend.Fields.Settings;
using PiranhaCMS.Models;
namespace PiranhaCMS.ContentTypes.Blocks
{
    [BlockType(Name = "Skills", Icon = "fas fa-sharp fa-solid fa-list", Category = Global.AboutCategory)]

    public class SkillsBlock : BlockBase
    {
        public SkillsBlock()
        {
            CssClass = new SelectField<SectionBlockCssClass>
            {
                Value = SectionBlockCssClass.white
            };
        }

         [Field(Title = "Título")]
        public StringField Title { get; set; }

        [Field(Title = "SubTítulo")]
        public StringField SubTitle { get; set; }

        /// <summary>
        /// Gets/sets the Welcome link.
        /// </summary>

        [ContentFieldSettings(Group = "Skills")]
        [Field(Title = "Skills")]
        public ContentField Body { get; set; }

        [Field(Title = "Section BG style")]
        public SelectField<SectionBlockCssClass> CssClass { get; set; }

        /// <summary>
        /// Gets the title of the block when used in a block group.
        /// </summary>
        /// <returns>The title</returns>
        public override string GetTitle()
        {
            if (Body != null && Body.Content != null)
            {
                return Body.Content.Title;
            }
            return "No content selected";
        }
    }
}

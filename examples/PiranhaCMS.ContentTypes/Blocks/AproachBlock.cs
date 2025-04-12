using PiranhaCMS.ContentTypes.Blocks.Base;
using PiranhaCMS.ContentTypes.Constants;

using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Extend.Fields.Settings;
using PiranhaCMS.Models;
namespace PiranhaCMS.ContentTypes.Blocks
{
    [BlockType(Name = "Missão", Icon = "fas fa-sharp fa-solid fa-door-open", Category = Global.AboutCategory)]

    public class AproachBlock : BlockBase
    {

        public AproachBlock()
        {
            CssClass = new SelectField<SectionBlockCssClass>
            {
                Value = SectionBlockCssClass.white
            };


        }

        /// <summary>
        /// Gets/sets the Title .
        /// </summary>

        [Field(Title = "Title")]
        public StringField Title { get; set; }

        /// <summary>
        /// Gets/sets the Description .
        /// </summary>

        [Field(Title = "Subtítulo")]
        public StringField Subtitle { get; set; }


        /// <summary>
        /// Gets/sets the Welcome link.
        /// </summary>

        [ContentFieldSettings(Group = "Missao")]
        [Field(Title = "Visão, Missão, Valor")]
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

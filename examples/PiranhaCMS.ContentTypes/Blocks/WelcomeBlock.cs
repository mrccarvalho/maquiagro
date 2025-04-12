using System.ComponentModel.DataAnnotations;
using System.Text;
using PiranhaCMS.ContentTypes.Blocks.Base;
using PiranhaCMS.ContentTypes.Constants;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Blocks;
using Piranha.Extend.Fields;
using Piranha.Extend.Fields.Settings;
using Piranha.Models;
using PiranhaCMS.Models;
namespace PiranhaCMS.ContentTypes.Blocks
{
    [BlockType(Name = "Welcome", Icon = "fas fa-sharp fa-solid fa-door-open", Category = Global.AboutCategory)]

    public class WelcomeBlock : BlockBase
    {

        public WelcomeBlock()
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

                [Field(Title = "SubTítulo2")]
        public StringField SubTitle2 { get; set; }

        /// <summary>
        /// Gets/sets the Welcome link.
        /// </summary>

        [ContentFieldSettings(Group = "Welcome")]
        [Field(Title = "Bem-Vindo")]
        public ContentField Body { get; set; }



        [Field(Title = "Cor de Fundo")]
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

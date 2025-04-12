using PiranhaCMS.ContentTypes.Blocks.Base;
using PiranhaCMS.ContentTypes.Constants;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Extend.Fields.Settings;
using PiranhaCMS.Models;
namespace PiranhaCMS.ContentTypes.Blocks
{
    [BlockType(Name = "Faq", Icon = "fas fa-sharp fa-solid fa-list-check", Category = Global.AboutCategory)]

    public class FaqBlock : BlockBase
    {
         public FaqBlock()
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

        [ContentFieldSettings(Group = "Faq")]
        [Field(Title = "Faq")]
        public ContentField Body { get; set; }

        [Field(Title = "Secção - Cor de Fundo")]
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

          public string GetCssClass()
        {
            switch (CssClass?.Value)
            {
                case SectionBlockCssClass.white:
                    return "bg-white";
                case SectionBlockCssClass.gray:
                    return "bg-gray";
                default:
                    return "";
            }
        }

    }


}

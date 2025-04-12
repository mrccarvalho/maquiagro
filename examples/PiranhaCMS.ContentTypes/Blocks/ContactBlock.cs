using System.Text;
using PiranhaCMS.ContentTypes.Blocks.Base;
using PiranhaCMS.ContentTypes.Constants;

using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Extend.Fields.Settings;
using PiranhaCMS.Models;


namespace PiranhaCMS.ContentTypes.Blocks
{
    [BlockType(Name = "Contactos", Icon = "fas fa-sharp fa-solid fa-phone", Category = Global.ContactosCategory)]

    public class ContactBlock : BlockBase
    {

        
        public ContactBlock()
        {
            CssClass = new SelectField<SectionBlockCssClass>
            {
                Value = SectionBlockCssClass.white
            };


        }

              /// <summary>
        /// Gets/sets the Welcome link.
        /// </summary>

        [Field(Title = "Title")]
        public StringField Title { get; set; }

        /// <summary>
        /// Gets/sets the Welcome link.
        /// </summary>

        [ContentFieldSettings(Group = "Contactos")]
        [Field(Title = "Contactos")]
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

using System.Text;
using PiranhaCMS.ContentTypes.Blocks.Base;
using PiranhaCMS.ContentTypes.Constants;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Extend.Fields.Settings;
using PiranhaCMS.Models;
namespace PiranhaCMS.ContentTypes.Blocks
{
    [BlockType(Name = "Notícias", Icon = "fas fa-sharp fa-solid fa-phone", Category = Global.NewsCategory)]

    public class NewsBlock : BlockBase
    {

        
        public NewsBlock()
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

        [Field(Title = "Description")]
        public StringField Description { get; set; }

            /// <summary>
        /// Gets/sets the archive
        /// </summary>

        [Field(Title = "Arquivo Notícias")]
        public PageField NewsArchive { get; set; }

      
        [Field(Title = "Section BG style")]
        public SelectField<SectionBlockCssClass> CssClass { get; set; }


        /// <summary>
        /// Gets the title of the block when used in a block group.
        /// </summary>
        /// <returns>The title</returns>
        public override string GetTitle()
        {
            if (Title != null )
            {
                return Title;
            }
            return "No content selected";
        }

    }


}

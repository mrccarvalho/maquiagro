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
    [BlockType(Name = "Projects", Icon = "fas fa-sharp fa-solid fa-door-open", Category = Global.MaquinasCategory)]

    public class ProjectsBlock : BlockBase
    {

        public ProjectsBlock()
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



        [Field(Title = "Section BG style")]
        public SelectField<SectionBlockCssClass> CssClass { get; set; }

        [Field(Title = "Categoria Ativa")]
        public DataSelectField<ArchiveItem> DataSelect { get; set; }


        /// <summary>
        /// Gets the title of the block when used in a block group.
        /// </summary>
        /// <returns>The title</returns>
     public override string GetTitle()
        {
      if (Title != null)
           {
              return Title;
           }
           return "No content selected";
      }

    }


}

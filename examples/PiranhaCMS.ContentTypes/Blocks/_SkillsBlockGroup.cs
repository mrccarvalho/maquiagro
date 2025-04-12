using System.ComponentModel.DataAnnotations;
using System.Text;
using PiranhaCMS.ContentTypes.Blocks.Base;
using PiranhaCMS.ContentTypes.Constants;
using PiranhaCMS.ContentTypes.Enums;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using PiranhaCMS.Models;
namespace PiranhaCMS.ContentTypes.Blocks
{
    [BlockGroupType(
        Name = "Skills",
        Icon = "fas fa-sharp fa-solid fa-list",
        Display = BlockDisplayMode.Vertical,
        Category = Global.AboutCategory)]
    [BlockItemType(Type = typeof(SkillsBlock))]
    public class _SkillsBlockGroup : BlockGroupBase, ISearchable
    {
        public _SkillsBlockGroup()
        {
            CssClass = new SelectField<SectionBlockCssClass>
            {
                Value = SectionBlockCssClass.white
            };

        }
        [Field(Title = "Imagem")]
        public ImageField Picture { get; set; }


        [Field(Title = "Título")]
        public StringField Title { get; set; }

        [Field(Title = "SubTítulo")]
        public StringField SubTitle { get; set; }


        [Field(Title = "Descrição")]
        public HtmlField Description { get; set; }

        [Field(Title = "Imagem Backround")]
        public ImageField Picture2 { get; set; }

        [Field(Title = "Backround Color")]
        public SelectField<SectionBlockCssClass> CssClass { get; set; }

        public string GetIndexedContent()
        {
            var sb = new StringBuilder();

            sb.AppendLine(Title.GetIndexedContent());
            sb.AppendLine(SubTitle.GetIndexedContent());

            return sb.ToString();
        }
    }
}

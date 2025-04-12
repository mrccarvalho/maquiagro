using System.ComponentModel.DataAnnotations;
using System.Text;
using PiranhaCMS.ContentTypes.Blocks.Base;
using PiranhaCMS.ContentTypes.Constants;

using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using PiranhaCMS.Models;
namespace PiranhaCMS.ContentTypes.Blocks
{
    [BlockGroupType(
        Name = "Counters",
        Icon = "fas fa-sharp fa-solid fa-list",
        Display = BlockDisplayMode.Vertical,
        Category = Global.AboutCategory)]
    [BlockItemType(Type = typeof(_CounterBlock))]
    public class _CounterBlockGroup : BlockGroupBase, ISearchable
    {
        public _CounterBlockGroup()
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

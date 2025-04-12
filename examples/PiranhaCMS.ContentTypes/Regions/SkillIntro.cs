using System.Text;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using PiranhaCMS.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    public class SkillIntro
    {
       public SkillIntro()
        {
            CssClass = new SelectField<SectionBlockCssClass>
            {
                Value = SectionBlockCssClass.white
            };
        }

        [Field(Title = "Imagem")]
        public ImageField Picture { get; set; }

        [Field(Title = "Descrição")]
        public HtmlField Description { get; set; }

        [Field(Title = "Imagem Backround")]
        public ImageField Picture2 { get; set; }

        [Field(Title = "Backround Color")]
        public SelectField<SectionBlockCssClass> CssClass { get; set; }

        public string GetIndexedContent()
        {
            var sb = new StringBuilder();

            sb.AppendLine(Description.GetIndexedContent());

            return sb.ToString();
        }


    }
}
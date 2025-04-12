using System.ComponentModel.DataAnnotations;
using System.Text;
using PiranhaCMS.ContentTypes.Blocks.Base;
using PiranhaCMS.ContentTypes.Constants;
using PiranhaCMS.ContentTypes.Enums;
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

    public class _WelcomeBlock : BlockBase
    {

        public _WelcomeBlock()
        {
            CssClass = new SelectField<SectionBlockCssClass>
            {
                Value = SectionBlockCssClass.white
            };

            AboutCssClass = new SelectField<AboutBlockCssClass>
            {
                Value = AboutBlockCssClass.right
            };
        }

        [Field(Title = "Imagem")]
        public ImageField Imagem { get; set; }

        [Field(Title = "Título")]
        public StringField Title { get; set; }

        [Field(Title = "SubTítulo")]
        public StringField SubTitle { get; set; }

        [Field(Title = "SubTítulo2")]
        public StringField SubTitle2 { get; set; }

        [Field(Title = "Topicos")]
        public HtmlField Topics { get; set; }

        [Field(Title = "Descrição")]
        public HtmlField Description { get; set; }

        [Field(Title = "Desde")]
        public StringField Since { get; set; }

        [Field(Title = "Ano Fundação")]
        public StringField Year { get; set; }

        [Field(Title = "Link Página")]
        public PageField PageLink { get; set; }

        [Field(Title = "CEO / Fundador")]
        public StringField FounderText { get; set; }

        [Field(Title = "Nome CEO / Fundador")]
        public StringField Founder { get; set; }

        [Field(Title = "Image Position")]
        public SelectField<AboutBlockCssClass> AboutCssClass { get; set; }

        [Field(Title = "Section BG style")]
        public SelectField<SectionBlockCssClass> CssClass { get; set; }




    }


}

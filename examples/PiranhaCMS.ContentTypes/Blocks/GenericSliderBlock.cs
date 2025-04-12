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
    [BlockType(Name = "OwlSliderBlock",
        Category = Global.BannersCategory, Icon = "fas fa-images")]

    public class GenericSliderBlock : BlockBase
    {

        public GenericSliderBlock()
        {
            CssClass = new SelectField<HeroCssClass>
            {
                Value = HeroCssClass.Small
            };

            BtnCssClass = new SelectField<ButtonCssClass>
            {
                Value = ButtonCssClass.Standard
            };
        }

        /// <summary>
        /// Gets/sets Título.
        /// </summary>
        [Field(Title = "Título")]
        public StringField Title { get; set; }

             /// <summary>
        /// Gets/sets Título.
        /// </summary>
        [Field(Title = "Título Linha 2")]
        public StringField Title2 { get; set; }

             /// <summary>
        /// Gets/sets Título.
        /// </summary>
        [Field(Title = "Título Linha 2 - Laranja")]
        public StringField Title3 { get; set; }

        /// <summary>
        /// Gets/sets optional subtítulo.
        /// </summary>
        [Field(Title = "SubTítulo")]
        public StringField SubTitle { get; set; }

        /// <summary>
        /// Gets/sets optional subsubtítulo.
        /// </summary>
        [Field(Title = "Descrição")]
        public StringField Description { get; set; }

        [Field(Title = "Imagem", Options = FieldOption.HalfWidth)]
        public DocumentField ImageBanner { get; set; }

        /// <summary>
        /// Gets/sets optional Datas.
        /// </summary>
        [Field(Title = "Datas", Options = FieldOption.HalfWidth)]
        public StringField Dates { get; set; }

        /// <summary>
        /// Gets/sets  optional Local.
        /// </summary>
        [Field(Title = "Local", Options = FieldOption.HalfWidth)]

        public StringField Local { get; set; }


        /// <summary>
        /// Gets/sets the optional ingresso.
        /// </summary>
        [Field(Title = "Aviso")]

        public HtmlField Ingress { get; set; }

        /// <summary>
        /// Gets/sets the optional primary image.
        /// </summary>
        [Field(Title = "Imagem de Fundo")]

        public ImageField PrimaryImage { get; set; }

        [Field(Title = "Hero style")]
        public SelectField<HeroCssClass> CssClass { get; set; }

        [Field(Title = "Page link", Options = FieldOption.HalfWidth)]
        public PageField Page { get; set; }

        [Field(Title = "Link externo", Options = FieldOption.HalfWidth)]
        public StringField ExternalUrl { get; set; }

        [Field(Title = "Texto Link", Options = FieldOption.HalfWidth)]
        public StringField LinkText { get; set; }

        [Field(Title = "Aria-Label", Options = FieldOption.HalfWidth)]
        public StringField AriaLabel { get; set; }

        [Field(Title = "Button style", Options = FieldOption.HalfWidth)]
        public SelectField<ButtonCssClass> BtnCssClass { get; set; }

        [Field(Title = "Abrir em nova janela ?", Options = FieldOption.HalfWidth)]
        public CheckBoxField OpenInNewWindow { get; set; }

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

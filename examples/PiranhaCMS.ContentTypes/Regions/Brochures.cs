using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using PiranhaCMS.Models;
namespace PiranhaCMS.ContentTypes.Regions
{
    public class Brochures
    {

        public Brochures()
        {
            CssClass = new SelectField<BrochureIconCssClass>
            {
                Value = BrochureIconCssClass.pdf
            };
        }

        [Field(Title = "Título")]
        public StringField Title { get; set; }


        [Field(Title = "Documento",  Options = FieldOption.HalfWidth)]
        public DocumentField Brochure { get; set; }

        [Field(Title = "Icon",  Options = FieldOption.HalfWidth)]
        public SelectField<BrochureIconCssClass> CssClass { get; set; }

        public string GetCssClass()
        {
            switch (CssClass?.Value)
            {
                case BrochureIconCssClass.pdf:
                    return "fa fa-pdf";
                case BrochureIconCssClass.word:
                    return "fa fa-word";
                default:
                    return "fa";
            }
        }



    }
}
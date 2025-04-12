using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    public class ProductSpecification
    {
        [Field(Title = "Dimensões")]
        public ImageField Size { get; set; }

        [Field(Title = "Peso")]
        public StringField Wheight { get; set; }

        [Field(Title = "Garantia")]
        public StringField Warranty { get; set; }

         [Field(Title = "Cor")]
        public StringField Color { get; set; }





    }
}
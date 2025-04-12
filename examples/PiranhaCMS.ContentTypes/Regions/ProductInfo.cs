using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    public class ProductInfo
    {


        [Field(Title = "Nome")]
        public StringField Title { get; set; }

        [Field(Title = "Sku")]
        public StringField Sku { get; set; }

                [Field(Title = "Preço")]
        public StringField Price { get; set; }

        [Field(Title = "Imagem Principal")]
        public ImageField Imagem { get; set; }

        [Field(Title = "Descrição")]
        public HtmlField Description { get; set; }



    }
}
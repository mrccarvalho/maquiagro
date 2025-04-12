using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    public class ProductImage
    {

        [Field(Title = "Imagem - Grande")]
        public ImageField BigImage { get; set; }

        [Field(Title = "Imagem - Pequena")]
        public ImageField ThumbnailImage { get; set; }


    }
}

using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    public class AproachInfo
    {

        [Field(Title = "Visão")]
        public StringField Vision { get; set; }

        [Field(Title = "Descrição Visão")]
        public HtmlField VisionDescription { get; set; }

        [Field(Title = "Missão")]
        public StringField Mission { get; set; }

        [Field(Title = "Descrição Missão")]
        public HtmlField MisssionDescription { get; set; }

            [Field(Title = "Valor")]
        public StringField Value { get; set; }

        [Field(Title = "Descrição Valor")]
        public HtmlField ValueDescription { get; set; }


        [Field(Title = "Imagem 1")]
        public ImageField Imagem1 { get; set; }

        [Field(Title = "Imagem 2")]
        public ImageField Imagem2 { get; set; }

          [Field(Title = "Imagem 3")]
        public ImageField Imagem3 { get; set; }

      
    }


}
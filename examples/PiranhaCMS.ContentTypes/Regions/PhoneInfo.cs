using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    public class PhoneInfo
    {


        [Field(Title = "Título")]
        public StringField Title { get; set; }

        [Field(Title = "Telefone")]
        public StringField Telefone { get; set; }





    }
}
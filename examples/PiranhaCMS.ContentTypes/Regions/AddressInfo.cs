using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    public class AddressInfo
    {


        [Field(Title = "Morada",  Options = FieldOption.HalfWidth)]
        public StringField Address { get; set; }

        [Field(Title = "Código Postal", Options = FieldOption.HalfWidth)]
        public StringField PostalCode { get; set; }

        [Field(Title = "País" , Options = FieldOption.HalfWidth)]
        public StringField Country { get; set; }
        [Field(Title = "Cidade",  Options = FieldOption.HalfWidth)]
        public StringField City { get; set; }


        [Field(Title = "Mapa")]
        public StringField Map { get; set; }

    }
}
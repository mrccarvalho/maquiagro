using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    public class EmailsInfo
    {


        [Field(Title = "Título")]
        public StringField Title { get; set; }

        [Field(Title = "Email")]
        public StringField Email { get; set; }





    }
}
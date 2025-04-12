using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    public class ContactPerson
    {
        [Field(Title = "Profile image")]
        public ImageField ProfileImage { get; set; }

        [Field(Title = "First name")]
        public StringField FirstName { get; set; }

        [Field(Title = "Last name")]
        public StringField LastName { get; set; }



    }
}
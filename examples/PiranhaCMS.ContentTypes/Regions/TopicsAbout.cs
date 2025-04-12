using System.ComponentModel.DataAnnotations;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    public class AboutTopics
    {

           
            [Required(ErrorMessage = "Heading: required!")]
            [StringLength(15, ErrorMessage = "Heading: maximum allowed characters is 15!")]
            public StringField Heading { get; set; }


   

    }
}
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using PiranhaCMS.ContentTypes.Blocks.Base;
using PiranhaCMS.ContentTypes.Constants;
using System.ComponentModel.DataAnnotations;

namespace PiranhaCMS.ContentTypes.Blocks
{
    [BlockType(
        Name = "Search block", 
        Category = Global.TeasersCategory)]
    public class SearchBlock : BlockBase
    {
        [Field(Title = "Heading", Placeholder = "Enter heading text", Options = FieldOption.HalfWidth)]

        [Required(ErrorMessage = "Heading: required!")]
        public StringField Heading { get; set; }
        
        [Field(Title = "Lead text", Placeholder = "Enter lead text", Options = FieldOption.HalfWidth)]

        [StringLength(50, ErrorMessage = "Lead text: maximum length is 50 characters!")]
        public TextField LeadText { get; set; }
    }
}

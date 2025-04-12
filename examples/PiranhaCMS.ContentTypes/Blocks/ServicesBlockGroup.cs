using PiranhaCMS.ContentTypes.Blocks.Base;
using PiranhaCMS.ContentTypes.Constants;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PiranhaCMS.ContentTypes.Blocks
{
    [BlockGroupType(
        Name = "Serviços", 
        Display = BlockDisplayMode.Vertical, 
        Category = Global.TeasersCategory)]
    [BlockItemType(Type = typeof(TeaserBlock))]
    public class ServicesBlockGroup : BlockGroupBase, ISearchable
    {
        [Field(Title = "Heading")]

        [Required(ErrorMessage = "Heading: required!")]
        public StringField Heading { get; set; }

        [Field(Title = "SubHeading")]

        [Required(ErrorMessage = "SubHeading: required!")]
        public StringField SubHeading { get; set; }

        #region ISearchable implementation

        public string GetIndexedContent()
        {
            var sb = new StringBuilder();

            sb.AppendLine(Heading.GetIndexedContent());
            sb.AppendLine(SubHeading.GetIndexedContent());

            return sb.ToString();
        }

        #endregion
    }
}

using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using System.ComponentModel.DataAnnotations;
using PiranhaCMS.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
public class SocialIcon
    {
        public SocialIcon()
        {
            CssClass = new SelectField<SocialIconCssClass>
            {
                Value = SocialIconCssClass.Facebook
            };
        }

        [Field(Title = "External link")]
        public StringField ExternalUrl { get; set; }

        [Field(Title = "Link text")]
        public StringField LinkText { get; set; }

        [Field(Title = "Open link in new window", Options = FieldOption.HalfWidth)]
        public CheckBoxField OpenInNewWindow { get; set; }

        [Field(Title = "Icon style")]
        public SelectField<SocialIconCssClass> CssClass { get; set; }

        public string GetLinkUrl()
        {
            return ExternalUrl;
        }

        public string GetCssClass()
        {
            switch (CssClass?.Value)
            {
                case SocialIconCssClass.Facebook:
                    return "fa fa-facebook";
                case SocialIconCssClass.Twitter:
                    return "fa fa-twitter";
                default:
                    return "fa";
            }
        }
    }
}



using PiranhaCMS.ContentTypes.Regions;
using System.Collections.Generic;
using System.Linq;
namespace PiranhaCMS.PublicWeb.Models.ViewModels
{
    public class SocialIconViewModel
    {
        public string ExternalUrl { get; set; }
        public string LinkText { get; set; }
      
        public IList<SocialIcon> SocialIcons { get; set; } = new List<SocialIcon>();
         
    }
}

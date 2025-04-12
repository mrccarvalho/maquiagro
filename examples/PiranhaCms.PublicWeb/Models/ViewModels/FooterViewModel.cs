
using PiranhaCMS.ContentTypes.Regions;
using System.Collections.Generic;
using System.Linq;

namespace PiranhaCMS.PublicWeb.Models.ViewModels
{
    public record FooterViewModel
    {
               public string FooterTitleColumn1 { get; set; }
        public string FooterColumn1 { get; set; }
        public string FooterTitleColumn2 { get; set; }
        public string FooterColumn2 { get; set; }
        public string FooterTitleColumn3 { get; set; }
        public string FooterColumn3 { get; set; }
        public string FooterTitleColumn4 { get; set; }
        public string FooterColumn4 { get; set; }
        public string FooterTitleColumn5 { get; set; }
        public string FooterColumn5 { get; set; }
        public string SiteTitle { get; set; }
    }
}

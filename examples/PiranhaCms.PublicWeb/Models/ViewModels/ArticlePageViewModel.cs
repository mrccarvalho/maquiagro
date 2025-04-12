using PiranhaCMS.Common.Extensions;
using PiranhaCMS.ContentTypes.Pages;
using System.Collections.Generic;
using System.Linq;
using PiranhaCMS.PublicWeb.Models.ViewModels.Base;

namespace PiranhaCMS.PublicWeb.Models.ViewModels
{
    public record ArticlePageViewModel : PageViewModel<ArticlePage>
    {
        public IEnumerable<SubMenuItem> SubMenu { get; set; }

        public ArticlePageViewModel(ArticlePage currentPage) : base(currentPage)
        {
            SubMenu = currentPage.GetChildrenPages()
                .Select(x => new SubMenuItem
                {
                    Name = x.Title,
                    Link = x.Permalink
                });
        }
    }

    public class SubMenuItem
    {
        public string Name { get; set; }
        public string Link { get; set; }
    }
}

using PiranhaCMS.ContentTypes.Pages;
using PiranhaCMS.ContentTypes.Regions;
using Piranha.Models;
using PiranhaCMS.PublicWeb.Models.ViewModels.Base;
namespace PiranhaCMS.PublicWeb.Models.ViewModels
{
    public record NewsPostPageViewModel : PageViewModel<NewsPost>
    {
                /// <summary>
        /// Gets/sets the latest post.
        /// </summary>
        public List<PostInfo> LatestPost { get; set; }
        public NewsPostPageViewModel(NewsPost currentPage) : base(currentPage)
        {     

            
        }
    }
}

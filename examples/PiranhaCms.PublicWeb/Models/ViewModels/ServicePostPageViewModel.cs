using PiranhaCMS.ContentTypes.Pages;
using PiranhaCMS.ContentTypes.Regions;
using Piranha.Models;
using PiranhaCMS.PublicWeb.Models.ViewModels.Base;
namespace PiranhaCMS.PublicWeb.Models.ViewModels
{
    public record ServicePostPageViewModel : PageViewModel<ServicePost>
    {
                /// <summary>
        /// Gets/sets the latest post.
        /// </summary>
        public List<PostInfo> LatestPost { get; set; }
        public ServicePostPageViewModel(ServicePost currentPage) : base(currentPage)
        {     

            
        }
    }
}

using PiranhaCMS.ContentTypes.Pages;
using PiranhaCMS.ContentTypes.Regions;
using PiranhaCMS.PublicWeb.Models.ViewModels.Base;

namespace PiranhaCMS.PublicWeb.Models.ViewModels
{
    public record RachadorPostPageViewModel  : PageViewModel<RachadorPost>
    {
        public RachadorPostPageViewModel (RachadorPost currentPage) : base(currentPage)
        {     
        }
    }
}

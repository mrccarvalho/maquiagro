using PiranhaCMS.ContentTypes.Pages;
using PiranhaCMS.ContentTypes.Regions;
using PiranhaCMS.PublicWeb.Models.ViewModels.Base;

namespace PiranhaCMS.PublicWeb.Models.ViewModels
{
    public record NewsArchivePageViewModel : PageViewModel<NewsArchive>
    {
        public NewsArchivePageViewModel(NewsArchive currentPage) : base(currentPage)
        {     
        }
    }
}

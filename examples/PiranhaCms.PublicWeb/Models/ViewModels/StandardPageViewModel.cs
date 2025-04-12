using PiranhaCMS.ContentTypes.Pages;
using PiranhaCMS.ContentTypes.Regions;
using PiranhaCMS.PublicWeb.Models.ViewModels.Base;

namespace PiranhaCMS.PublicWeb.Models.ViewModels
{
    public record StandardPageViewModel : PageViewModel<StandardPage>
    {
        public StandardPageViewModel(StandardPage currentPage) : base(currentPage)
        {     
        }
    }
}

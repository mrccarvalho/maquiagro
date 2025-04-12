using PiranhaCMS.ContentTypes.Pages;
using PiranhaCMS.ContentTypes.Regions;
using PiranhaCMS.PublicWeb.Models.ViewModels.Base;

namespace PiranhaCMS.PublicWeb.Models.ViewModels
{
    public record MaquinasPageViewModel : PageViewModel<MaquinasPage>
    {
        public MaquinasPageViewModel(MaquinasPage currentPage) : base(currentPage)
        {     
        }
    }
}

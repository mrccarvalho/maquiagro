using PiranhaCMS.ContentTypes.Pages;
using PiranhaCMS.ContentTypes.Regions;
using PiranhaCMS.PublicWeb.Models.ViewModels.Base;

namespace PiranhaCMS.PublicWeb.Models.ViewModels
{
    public record MaquinasArchivePageViewModel : PageViewModel<MaquinasArchive>
    {
        public MaquinasArchivePageViewModel(MaquinasArchive currentPage) : base(currentPage)
        {     
        }
    }
}

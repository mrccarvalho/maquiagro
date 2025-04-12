using PiranhaCMS.ContentTypes.Pages;
using PiranhaCMS.ContentTypes.Regions;
using PiranhaCMS.PublicWeb.Models.ViewModels.Base;

namespace PiranhaCMS.PublicWeb.Models.ViewModels
{
    public record ContactPageViewModel : PageViewModel<ContactPage>
    {
        public ContactPageViewModel(ContactPage currentPage) : base(currentPage)
        {     
        }
    }
}

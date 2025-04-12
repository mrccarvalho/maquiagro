using PiranhaCMS.ContentTypes.Pages;
using PiranhaCMS.ContentTypes.Regions;
using PiranhaCMS.PublicWeb.Models.ViewModels.Base;

namespace PiranhaCMS.PublicWeb.Models.ViewModels
{
    public record CapinadeirasPostPageViewModel  : PageViewModel<CapinadeirasPost>
    {
        public CapinadeirasPostPageViewModel (CapinadeirasPost currentPage) : base(currentPage)
        {     
        }
    }
}

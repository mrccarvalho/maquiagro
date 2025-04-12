using PiranhaCMS.ContentTypes.Pages;
using PiranhaCMS.ContentTypes.Regions;
using PiranhaCMS.PublicWeb.Models.ViewModels.Base;

namespace PiranhaCMS.PublicWeb.Models.ViewModels
{
    public record AtreladosPostPageViewModel  : PageViewModel<AtreladosPost>
    {
        public AtreladosPostPageViewModel (AtreladosPost currentPage) : base(currentPage)
        {     
        }
    }
}

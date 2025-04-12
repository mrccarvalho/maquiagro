using PiranhaCMS.ContentTypes.Pages;
using PiranhaCMS.ContentTypes.Regions;
using PiranhaCMS.PublicWeb.Models.ViewModels.Base;

namespace PiranhaCMS.PublicWeb.Models.ViewModels
{
    public record ProjectsArchivePageViewModel : PageViewModel<ProjectsArchive>
    {
        public ProjectsArchivePageViewModel(ProjectsArchive currentPage) : base(currentPage)
        {     
        }
    }
}

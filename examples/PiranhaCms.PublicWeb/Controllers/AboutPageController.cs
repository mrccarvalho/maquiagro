using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Piranha;
using Piranha.AspNetCore.Services;
using Piranha.Models;
using PiranhaCMS.ContentTypes.Pages;
using PiranhaCMS.Models;
using PiranhaCMS.PublicWeb.Models.ViewModels;
using PiranhaCMS.Search.Engine;

namespace PiranhaCMS.PublicWeb.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class AboutPageController : Controller
    {
        private readonly IModelLoader _loader;
        private readonly ISearchIndexEngine _searchIndexEngine;

        public AboutPageController(IModelLoader loader, ISearchIndexEngine searchIndexEngine)
        {
            _loader = loader;
            _searchIndexEngine = searchIndexEngine;
        }

        [ResponseCache(Duration = 36000, VaryByQueryKeys = ["id"])]
        [Route(nameof(AboutPage))]
        public async Task<IActionResult> AboutPage(Guid id, bool draft = false)
        {
            var currentPage = await _loader.GetPageAsync<AboutPage>(id, HttpContext.User, draft);
            var viewModel = new AboutPageViewModel(currentPage);

            return View(viewModel);
        }


    }
}

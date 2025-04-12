using Microsoft.AspNetCore.Mvc;
using Piranha;
using Piranha.AspNetCore.Services;
using Piranha.Models;
using PiranhaCMS.Models;
using PiranhaCMS.ContentTypes.Pages;
using PiranhaCMS.PublicWeb.Models.ViewModels;
using PiranhaCMS.Search.Engine;
using System;
using System.Threading.Tasks;

namespace PiranhaCMS.PublicWeb.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class StartPageController : Controller
    {
        private readonly IModelLoader _loader;
        private readonly ISearchIndexEngine _searchIndexEngine;
    
         public StartPageController(IModelLoader loader, ISearchIndexEngine searchIndexEngine)
        {
            _loader = loader;
            _searchIndexEngine = searchIndexEngine;
        }

        [ResponseCache(Duration = 36000, VaryByQueryKeys = ["id"])]
    [Route(nameof(StartPage))]
        public async Task<IActionResult> StartPage(Guid id, bool draft = false)
        {
            var currentPage = await _loader.GetPageAsync<StartPage>(id, HttpContext.User, draft);
            var viewModel = new StartPageViewModel(currentPage);

            return View(viewModel);
        }

        
    }
}

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
    public class StandardPageController : Controller
    {
        private readonly IModelLoader _loader;
        private readonly ISearchIndexEngine _searchIndexEngine;
    
         public StandardPageController(IModelLoader loader, ISearchIndexEngine searchIndexEngine)
        {
            _loader = loader;
            _searchIndexEngine = searchIndexEngine;
        }

       [Route("standardpage")]
        public async Task<IActionResult> StandardPage(Guid id, bool draft = false)
        {
            var currentPage = await _loader.GetPageAsync<StandardPage>(id, HttpContext.User, draft);
            var viewModel = new StandardPageViewModel(currentPage);

            return View(viewModel);
        }

        
    }
}

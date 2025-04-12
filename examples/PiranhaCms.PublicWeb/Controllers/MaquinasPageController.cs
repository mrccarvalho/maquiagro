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
    public class MaquinasPageController : Controller
    {
        private readonly IModelLoader _loader;
        private readonly ISearchIndexEngine _searchIndexEngine;
    
         public MaquinasPageController(IModelLoader loader, ISearchIndexEngine searchIndexEngine)
        {
            _loader = loader;
            _searchIndexEngine = searchIndexEngine;
        }

       [Route("maquinaspage")]
        public async Task<IActionResult> MaquinasPage(Guid id, bool draft = false)
        {
            var currentPage = await _loader.GetPageAsync<MaquinasPage>(id, HttpContext.User, draft);
            var viewModel = new MaquinasPageViewModel(currentPage);

            return View(viewModel);
        }

        
    }
}

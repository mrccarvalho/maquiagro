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
    public class ContactPageController : Controller
    {
        private readonly IModelLoader _loader;
        private readonly ISearchIndexEngine _searchIndexEngine;
    
         public ContactPageController(IModelLoader loader, ISearchIndexEngine searchIndexEngine)
        {
            _loader = loader;
            _searchIndexEngine = searchIndexEngine;
        }

       [Route("contactospage")]
        public async Task<IActionResult> ContactPage(Guid id, bool draft = false)
        {
            var currentPage = await _loader.GetPageAsync<ContactPage>(id, HttpContext.User, draft);
            var viewModel = new ContactPageViewModel(currentPage);

            return View(viewModel);
        }

        
    }
}

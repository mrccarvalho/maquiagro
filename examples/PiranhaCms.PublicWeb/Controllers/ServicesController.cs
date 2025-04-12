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
    public class ServicesController : Controller
    {
        private readonly IModelLoader _loader;
        private readonly ISearchIndexEngine _searchIndexEngine;
          /// <param name="api">The current api</param>
         private readonly IApi _api;


        private readonly IDb _db;
    
         public ServicesController(IApi api, IModelLoader loader, IDb db, ISearchIndexEngine searchIndexEngine)
        {
            _loader = loader;
            _searchIndexEngine = searchIndexEngine;
             _api = api;
             _db = db;
        }

         /// <summary>
        /// Gets the blog archive with the given id.
        /// </summary>
        /// <param name="id">The unique page id</param>
        /// <param name="year">The optional year</param>
        /// <param name="month">The optional month</param>
        /// <param name="page">The optional page</param>
        /// <param name="category">The optional category</param>
        /// <param name="tag">The optional tag</param>
        /// <param name="draft">If a draft is requested</param>
        [Route("servicos")]
        public async Task<IActionResult> ServicesArchive(Guid id, int? year = null, int? month = null, int? page = null,
            Guid? category = null, Guid? tag = null, bool draft = false)
        {
            try
            {
               // var model = await _loader.GetPageAsync<StandardArchive>(id, HttpContext.User, draft);
               // model.Archive = await _api.Archives.GetByIdAsync<PostInfo>(id, page, category, tag, year, month);

               // return View(model);

                var currentPage = await _loader.GetPageAsync<ServicesArchive>(id, HttpContext.User, draft);
                currentPage.Archive = await _api.Archives.GetByIdAsync<ServicePost>(id, page, category, tag, year, month);

                var viewModel = new ServicesArchivePageViewModel(currentPage);

                return View(viewModel);
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized();
            }
        }

        
        


        /// <summary>
        /// Gets the post with the given id.
        /// </summary>
        /// <param name="id">The unique post id</param>
        /// <param name="draft">If a draft is requested</param>
        [Route("servicoitem")]
        public async Task<IActionResult> ServicePost(Guid id, bool draft = false)
        {
            try
            {
                var currentPage = await _loader.GetPostAsync<ServicePost>(id, HttpContext.User, draft);

              //  if (model.IsCommentsOpen)
               // {
                 //   model.Comments = await _api.Posts.GetAllCommentsAsync(model.Id, true);
                //}
                 var viewModel = new ServicePostPageViewModel(currentPage);
                return View(viewModel);
            }
            catch
            {
                return Unauthorized();
            }
        }
      
    }
}

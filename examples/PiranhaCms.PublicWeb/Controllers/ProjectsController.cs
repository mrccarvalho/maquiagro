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
    public class ProjectsController : Controller
    {
        private readonly IModelLoader _loader;
        private readonly ISearchIndexEngine _searchIndexEngine;
          /// <param name="api">The current api</param>
         private readonly IApi _api;
    
         public ProjectsController(IApi api, IModelLoader loader, ISearchIndexEngine searchIndexEngine)
        {
            _loader = loader;
            _searchIndexEngine = searchIndexEngine;
             _api = api;
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
        [Route("projetos")]
        public async Task<IActionResult> ProjectsArchive(Guid id, int? year = null, int? month = null, int? page = null,
            Guid? category = null, Guid? tag = null, bool draft = false)
        {
            try
            {
               // var model = await _loader.GetPageAsync<StandardArchive>(id, HttpContext.User, draft);
               // model.Archive = await _api.Archives.GetByIdAsync<PostInfo>(id, page, category, tag, year, month);

               // return View(model);

                var currentPage = await _loader.GetPageAsync<ProjectsArchive>(id, HttpContext.User, draft);
                currentPage.Archive = await _api.Archives.GetByIdAsync<PostInfo>(id, page, category, tag, year, month);

                var viewModel = new ProjectsArchivePageViewModel(currentPage);

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
        [Route("projetoitem")]
        public async Task<IActionResult> ProjectPost(Guid id, bool draft = false)
        {
            try
            {
                var currentPage = await _loader.GetPostAsync<ProjectPost>(id, HttpContext.User, draft);

              //  if (model.IsCommentsOpen)
               // {
                 //   model.Comments = await _api.Posts.GetAllCommentsAsync(model.Id, true);
                //}
                 var viewModel = new ProjectPostPageViewModel(currentPage);
                return View(viewModel);
            }
            catch
            {
                return Unauthorized();
            }
        }


       
      
      
    }
}

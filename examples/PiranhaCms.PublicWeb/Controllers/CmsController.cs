using Microsoft.AspNetCore.Mvc;
using Piranha.AspNetCore.Services;
using PiranhaCMS.ContentTypes.Pages;
using PiranhaCMS.PublicWeb.Models.ViewModelFactories.Base;
using PiranhaCMS.PublicWeb.Models.ViewModels;
using PiranhaCMS.Search.Engine;

namespace PiranhaCMS.PublicWeb.Controllers;

public class CmsController : Controller
{
    private readonly IModelLoader _loader;

    public CmsController(IModelLoader loader)
    {
        _loader = loader;
    }

    [ResponseCache(Duration = 36000, VaryByQueryKeys = ["id"])]
    [Route(nameof(ArticlePage))]
    public async Task<IActionResult> ArticlePage(Guid id, bool draft = false)
    {
        var currentPage = await _loader.GetPageAsync<ArticlePage>(id, HttpContext.User, draft);
        var viewModel = new ArticlePageViewModel(currentPage);

        return View(viewModel);
    }

    [ResponseCache(Duration = 36000, VaryByQueryKeys = ["id"])]
    [Route(nameof(ArticleListPage))]
    public async Task<IActionResult> ArticleListPage(Guid id, bool draft = false)
    {
        var currentPage = await _loader.GetPageAsync<ArticleListPage>(id, HttpContext.User, draft);
        var viewModel = new ArticleListPageViewModel(currentPage);

        return View(viewModel);
    }
   
    [ResponseCache(Duration = 36000, VaryByQueryKeys = ["id", "q"])]
    [Route(nameof(SearchPage))]
    public async Task<IActionResult> SearchPage([FromServices] ISearchIndexEngine engine, Guid id, bool draft = false)
    {
        var currentPage = await _loader.GetPageAsync<SearchPage>(id, HttpContext.User, draft);
        var viewModel = new SearchPageViewModel(currentPage, HttpContext.Request, engine);

        return View(viewModel);
    }
    
    [ResponseCache(Duration = 36000, VaryByQueryKeys = ["id"])]
    [Route(nameof(NotFoundPage))]
    public async Task<IActionResult> NotFoundPage(Guid id, bool draft = false)
    {
        var currentPage = await _loader.GetPageAsync<NotFoundPage>(id, HttpContext.User, draft);
        var viewModel = new NotFoundPageViewModel(currentPage);

        return View(viewModel);
    }
}

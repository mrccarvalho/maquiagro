using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Piranha.AspNetCore.Services;
using Piranha.Models;
using PiranhaCMS.ContentTypes.Pages;
using PiranhaCMS.ContentTypes.Pages.Base;
using PiranhaCMS.ContentTypes.Sites;
using PiranhaCMS.PublicWeb.Models.ViewModels;
using PiranhaCMS.PublicWeb.Models.ViewModels.Base;

namespace PiranhaCMS.PublicWeb.Filters;

public class PageContextActionFilter : IAsyncResultFilter
{
    private readonly IApplicationService _applicationService;
    private const string ManagerAreaName = "Manager";

    public PageContextActionFilter(IApplicationService applicationService)
    {
        _applicationService = applicationService;
    }

    public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
    {
        if (context.RouteData.Values["area"]?.ToString() == ManagerAreaName)
        {
            await next();
            return;
        }

        var viewModel = (context.Result as ViewResult)?.Model;

        if (viewModel is not IPageViewModel<IPage> model)
        {
            await next();
            return;
        }

        var siteGlobal = await _applicationService.Api.Sites.GetDefaultAsync();
        var site = await _applicationService.Site.GetContentAsync<PublicSite>();
        var startPage = await _applicationService.Api.Pages.GetStartpageAsync();

        model.GlobalSettings = new GlobalSettingsViewModel
        {
            LanguageCode = _applicationService.Site.Culture,
            StartPageId = startPage.Id,
            EmailAddress = site.GlobalSettings?.EmailAddress?.Value,
            PhoneNumber = site.GlobalSettings?.PhoneNumber?.Value,
            SiteTitle = site.Title,
            PageTitle = model.CurrentPage is StartPage
                ? site.Title
                : $"{(model.CurrentPage as PageBase)?.Title} | {site.Title}"
        };
        

        model.Footer = new FooterViewModel
        {
            FooterTitleColumn1 = site.SiteFooter?.FooterTitleColumn1?.Value,
            FooterTitleColumn2 = site.SiteFooter?.FooterTitleColumn2?.Value,
            FooterTitleColumn3 = site.SiteFooter?.FooterTitleColumn3?.Value,
            FooterTitleColumn4 = site.SiteFooter?.FooterTitleColumn4?.Value,
            FooterTitleColumn5 = site.SiteFooter?.FooterTitleColumn5?.Value,
            FooterColumn1 = site.SiteFooter?.FooterColumn1?.Value,
            FooterColumn2 = site.SiteFooter?.FooterColumn2?.Value,
            FooterColumn3 = site.SiteFooter?.FooterColumn3?.Value,
            FooterColumn4 = site.SiteFooter?.FooterColumn4?.Value,
        };

        model.SocialIconVm = new SocialIconViewModel
        {
            SocialIcons = site.SocialIcons,
            //SiteLogoImageUrl = site.SiteHeader.LogoImage?.Media?.PublicUrl
        };

        model.Header = new HeaderViewModel
        {
            SiteName = site.SiteHeader.SiteName,
            SiteLogoImageUrl = site.SiteHeader.LogoImage?.Media?.PublicUrl,
            Dias = site.SiteHeader.Dias,
            Horas = site.SiteHeader.Horas,
            Telefone = site.SiteHeader.Telefone,
            Email = site.SiteHeader.Email
        };

           model.PageTitle = model.CurrentPage is StartPage ? 
                site.SiteHeader.SiteName.Value : 
                $"{(model.CurrentPage as PageBase)?.Title} | {site.SiteHeader.SiteName.Value}";

            model.StartPageId = startPage.Id;
            model.LanguageCode = _applicationService.Site.Culture;

        await next();
    }
}

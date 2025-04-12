using System.Text.Json.Serialization;
using PiranhaCMS.ContentTypes.Pages.Base;

namespace PiranhaCMS.PublicWeb.Models.ViewModels.Base;

public abstract record PageViewModel<T> : IPageViewModel<T> where T : IPage
{
    public PageViewModel(T currentPage)
    {
        CurrentPage = currentPage;
        Header = new HeaderViewModel();
        Footer = new FooterViewModel();
        GlobalSettings = new GlobalSettingsViewModel();
        SocialIconVm =  new SocialIconViewModel();
    }

    [JsonIgnore]
    public T CurrentPage { get; }
    public Guid StartPageId { get; set; }
    public string PageTitle { get; set; }
    public string LanguageCode { get; set; }
    public HeaderViewModel Header { get; set; }
    public FooterViewModel Footer { get; set; }
    public SocialIconViewModel SocialIconVm { get; set; }
        public GlobalSettingsViewModel GlobalSettings { get; set; }
}

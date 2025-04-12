using System.Text.Json.Serialization;
using PiranhaCMS.ContentTypes.Pages.Base;

namespace PiranhaCMS.PublicWeb.Models.ViewModels.Base;

public interface IPageViewModel<out T> where T : IPage
{
    [JsonIgnore]
    T CurrentPage { get; }
    string PageTitle { get; set; }
    string LanguageCode { get; set; }
    Guid StartPageId { get; set; }
    HeaderViewModel Header { get; set; }
    FooterViewModel Footer { get; set; }
    SocialIconViewModel SocialIconVm { get; set; }
    GlobalSettingsViewModel GlobalSettings { get; set; }
}

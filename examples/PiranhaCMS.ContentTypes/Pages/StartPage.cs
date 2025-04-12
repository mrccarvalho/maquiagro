using PiranhaCMS.ContentTypes.Blocks;
using PiranhaCMS.ContentTypes.Pages.Base;
using PiranhaCMS.ContentTypes.Regions;
using PiranhaCMS.Validators.Attributes;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Pages
{
    [PageType(Title = "Start page", UseBlocks = true)]
    [ContentTypeRoute(Title = "Default", Route = $"/{nameof(StartPage)}")]
    [AllowedPageTypes(Availability.None)]
    [BlockItemType(typeof(WelcomeBlock))]
    [BlockItemType(typeof(NewsBlock))]
    [BlockItemType(typeof(SkillsBlock))]
    //[BlockItemType(typeof(CounterBlockGroup))]
    [BlockItemType(typeof(CounterBlock))]
    [BlockItemType(typeof(ProjectsBlock))]
    
    public class StartPage : Page<StartPage>, IPage
    {
        [Region(Title = "Slider", ListTitle = "Title", Description = "Banners")]
        public IList<GenericSlider> GenericSliderItems { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using PiranhaCMS.ContentTypes.Pages;
using PiranhaCMS.ContentTypes.Regions;
using PiranhaCMS.Validators.Attributes;

namespace PiranhaCMS.ContentTypes.Sites
{
    [SiteType(Title = "Public site")]
    [AllowedPageTypes(new[]

    {
        typeof(AboutPage),
        typeof(MaquinasArchive),
        typeof(MaquinasPage),
        typeof(CapinadeirasPost),
        typeof(AtreladosPost),
        typeof(RachadorPost),
        typeof(ServicesArchive),
        typeof(ServicePost),
        typeof(NewsArchive),
        typeof(NewsPost),
        typeof(ProjectsArchive),
        typeof(ProjectPost),
        typeof(StandardPage),
        typeof(ArticlePage),
        typeof(SearchPage),
        typeof(ArticleListPage),
        typeof(StartPage),
        typeof(ContactPage)

    })]

    public class PublicSite : SiteContent<PublicSite>
    {
        [Region(Title = "Cabeçalho", Display = RegionDisplayMode.Content)]
        public SiteHeader SiteHeader { get; set; }

        [Region(Title = "Site footer", Display = RegionDisplayMode.Setting)]
        public SiteFooter SiteFooter { get; set; }

        [Region(Title = "Rodapé-Contactos")]
        public SiteFooterContacts SiteFooterContacts { get; set; }

        [Region(Title = "Rodapé-R. Sociais", ListTitle = "LinkText", Display = RegionDisplayMode.Setting)]
        public IList<SocialIcon> SocialIcons { get; set; }


        [Region(Title = "Global settings", Display = RegionDisplayMode.Setting)]
        public GlobalSettings GlobalSettings { get; set; }
    }

    public class SiteFooter
    {
        [Field(Title = "Título Column 1")]
        public StringField FooterTitleColumn1 { get; set; }

        [Field(Title = "Column 1")]
        public HtmlField FooterColumn1 { get; set; }

        [Field(Title = "Título Column 2")]
        public StringField FooterTitleColumn2 { get; set; }

        [Field(Title = "Column 2")]
        public HtmlField FooterColumn2 { get; set; }


        [Field(Title = "Título Column 3")]
        public StringField FooterTitleColumn3 { get; set; }

        [Field(Title = "Column 3")]
        public HtmlField FooterColumn3 { get; set; }

        [Field(Title = "Título Column 4")]
        public StringField FooterTitleColumn4 { get; set; }


        [Field(Title = "Column 4")]
        public HtmlField FooterColumn4 { get; set; }

        [Field(Title = "Título Coluna Redes Socias")]
        public StringField FooterTitleColumn5 { get; set; }

    }

    public class SiteFooterContacts
    {
        [Field(Title = "Sobre")]
        public StringField About { get; set; }

        [Field(Title = "Rua")]
        public StringField Street { get; set; }

        [Field(Title = "Localidade")]
        public StringField City { get; set; }

        [Field(Title = "Email")]
        public StringField Email { get; set; }

        [Field(Title = "Telefone")]
        public StringField Phone { get; set; }


    }

    public class SiteHeader
    {
        [Field(Title = "Site name", Options = FieldOption.HalfWidth)]
        [Required(ErrorMessage = "Site name: required!")]
        public StringField SiteName { get; set; }


        [Field(Title = "Logo", Options = FieldOption.HalfWidth)]
        public DocumentField LogoImage { get; set; }


        [Field(Title = "Horário - Dias da Semana", Options = FieldOption.HalfWidth)]
        public StringField Dias { get; set; }

        [Field(Title = "Horário - Horas", Options = FieldOption.HalfWidth)]
        public StringField Horas { get; set; }

        [Field(Title = "Telefone", Options = FieldOption.HalfWidth)]
        public StringField Telefone { get; set; }

        [Field(Title = "Email", Options = FieldOption.HalfWidth)]
        public StringField Email { get; set; }

    }

    public class GlobalSettings
    {
        [Field(
            Title = "Logo Image",
            Description = "Select logo image, SVG supported")]
        [AllowedImageExtension]
        public DocumentField LogoImage { get; set; }

        [Field(
            Title = "Contact E-mail Address",
            Options = FieldOption.HalfWidth,
            Description = "E-mail address")]
        public StringField EmailAddress { get; set; }

        [Field(
            Title = "Contact Phone Number",
            Options = FieldOption.HalfWidth,
            Description = "Phone number")]
        public StringField PhoneNumber { get; set; }

        [Field(
            Title = "Search Page Reference",
            Options = FieldOption.HalfWidth,
            Description = "Reference to search page")]
        public PageField SearchPageReference { get; set; }

        [Field(
            Title = "Page Size",
            Options = FieldOption.HalfWidth,
            Description = "Number of search results per page")]
        public NumberField PageSize { get; set; }


    }

}

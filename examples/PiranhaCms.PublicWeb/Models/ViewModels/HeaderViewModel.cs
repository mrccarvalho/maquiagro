namespace PiranhaCMS.PublicWeb.Models.ViewModels
{
    public record HeaderViewModel
    {
        public string SiteLogoImageUrl { get; set; }
        public string SiteName { get; set; }
        public string Dias { get; set; }
        public string Horas { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}

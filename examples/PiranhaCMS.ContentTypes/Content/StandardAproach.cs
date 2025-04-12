using PiranhaCMS.ContentTypes.Regions;
using PiranhaCMS.Validators.Attributes;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Content
{
    /// <summary>
    /// .
    /// </summary>
    [ContentType(Title = "Missao", UsePrimaryImage = false, UseExcerpt = false)]
    public class StandardAproach : Aproach<StandardAproach>
    {
        [Region(Title = "Missão, Visão, Valor", Description = "Missão, Visão, Valor")]
        public AproachInfo aproachInfo { get; set; }



    }
}

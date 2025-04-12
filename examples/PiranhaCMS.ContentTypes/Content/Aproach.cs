
using System.Collections.Generic;
using Piranha.Extend;
using Piranha.Models;
using Piranha.Extend.Fields;

namespace PiranhaCMS.ContentTypes.Content
{
    [ContentGroup(Title = "Missao", Icon = "fas fa-sharp fa-solid fa-door-open")]
 
    public abstract class Aproach<T> : Content<T>,  IBlockContent
        where T : Aproach<T>
    {

        public IList<Block> Blocks { get; set; } = new List<Block>();

    
    }
}
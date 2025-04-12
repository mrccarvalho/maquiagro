
using System.Collections.Generic;
using Piranha.Extend;
using Piranha.Models;
using Piranha.Extend.Fields;

namespace PiranhaCMS.ContentTypes.Content
{
    [ContentGroup(Title = "Sobre", Icon = "fas fa-building")]
    public abstract class About<T> : Content<T>,  IBlockContent
        where T : About<T>
    {

        public IList<Block> Blocks { get; set; } = new List<Block>();

    
    }
}
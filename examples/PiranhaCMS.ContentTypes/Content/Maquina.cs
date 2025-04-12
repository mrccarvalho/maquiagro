
using System.Collections.Generic;
using Piranha.Extend;
using Piranha.Models;
using Piranha.Extend.Fields;

namespace PiranhaCMS.ContentTypes.Content
{
    [ContentGroup(Title = "Maquinas", Icon = "fas fa-list")]
    public abstract class Maquina<T> : Content<T>
        where T : Maquina<T>
    {
    
    }
}
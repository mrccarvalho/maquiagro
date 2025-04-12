
using System.Collections.Generic;
using Piranha.Extend;
using Piranha.Models;
using Piranha.Extend.Fields;

namespace PiranhaCMS.ContentTypes.Content
{
    [ContentGroup(Title = "Welcome", Icon = "fas fa-sharp fa-solid fa-door-open")]
    public abstract class Welcome<T> : Content<T>
        where T : Welcome<T>
    {
    
    }
}
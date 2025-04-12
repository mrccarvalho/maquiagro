
using System.Collections.Generic;
using Piranha.Extend;
using Piranha.Models;
using Piranha.Extend.Fields;

namespace PiranhaCMS.ContentTypes.Content
{
    [ContentGroup(Title = "Faq", Icon = "fas fa-question")]
    public abstract class Faq<T> : Content<T>
        where T : Faq<T>
    {
    
    }
}
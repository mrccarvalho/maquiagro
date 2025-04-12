
using System.Collections.Generic;
using Piranha.Extend;
using Piranha.Models;
using Piranha.Extend.Fields;

namespace PiranhaCMS.ContentTypes.Content
{
    [ContentGroup(Title = "Counters", Icon = "fas fa-list-ul")]
    public abstract class Counter<T> : Content<T>
        where T : Counter<T>
    {
    
    }
}

using System.Collections.Generic;
using Piranha.Extend;
using Piranha.Models;
using Piranha.Extend.Fields;

namespace PiranhaCMS.ContentTypes.Content
{
    [ContentGroup(Title = "Skills", Icon = "fas fa-list")]
    public abstract class Skill<T> : Content<T>
        where T : Skill<T>
    {
    
    }
}

using System.Collections.Generic;
using Piranha.Extend;
using Piranha.Models;
using Piranha.Extend.Fields;

namespace PiranhaCMS.ContentTypes.Content
{
    [ContentGroup(Title = "Contactos", Icon = "fas fa-phone")]
    public abstract class Contact<T> : Content<T>
        where T : Contact<T>
    {
    
    }
}
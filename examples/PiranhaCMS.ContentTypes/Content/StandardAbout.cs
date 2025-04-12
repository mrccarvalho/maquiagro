/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/tidyui/coreweb
 *
 */

using PiranhaCMS.ContentTypes.Regions;
using PiranhaCMS.Validators.Attributes;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;

using PiranhaCMS.Models.Fields;

namespace PiranhaCMS.ContentTypes.Content
{
    /// <summary>
    /// .
    /// </summary>
    [ContentType(Title = "About", UsePrimaryImage = false, UseExcerpt = false)]
    
    public class StandardAbout : About<StandardAbout>
    {
       
        [Region(Title = "Quem Somos", Description="Quem Somos")]
        public AboutInfo aboutInfo { get; set; }


        [Region(Title = "Topicos", Description = "Tópicos")]
                public IList<AboutTopics> topicsAbout { get; set; }



    }

    

    
}

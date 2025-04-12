/*
 * Copyright (c) 2017-2018 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/tidyui/coreweb
 *
 */

using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    /// <summary>
    /// Simple hero region.
    /// </summary>
    public class SimpleHero
    {
         /// <summary>
        /// Gets/sets the optional primary image.
        /// </summary>
        [Field(Title = "Background image")]
        public ImageField BackgroundImage { get; set; }

        /// <summary>
        /// Gets/sets the optional heading.
        /// </summary>
        [Field]
        public StringField Heading { get; set; }
    }
}

/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/tidyui/coreweb
 *
 */

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PiranhaCMS.Models.Fields;
using PiranhaCMS.ContentTypes.Regions;
using PiranhaCMS.Validators.Attributes;
using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Extend.Fields.Settings;
using Piranha.Models;

namespace PiranhaCMS.ContentTypes.Content
{
    /// <summary>
    /// .
    /// </summary>
    [ContentType(Title = "Counters", UsePrimaryImage = false, UseExcerpt = false)]

    public class StandardCounter : Counter<StandardCounter>
    {
        [Region(Title = "Counters / Metas", ListTitle = "Title",  Description = "Counters / Metas")]
        public IList<CounterInfo> Counters { get; set; }

    }

}

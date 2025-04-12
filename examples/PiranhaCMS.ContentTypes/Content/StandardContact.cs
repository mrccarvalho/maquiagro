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
    [ContentType(Title = "Contactos", UsePrimaryImage = false, UseExcerpt = false)]

    public class StandardContact : Contact<StandardContact>
    {

       // [Region(Title = "Cabeçalho", Description = "Títulos e Imagem")]
        //public FaqIntro FaqInfo { get; set; }


        [Region(Title = "Emails", ListTitle = "Title", Description = "Emails")]
        public IList<EmailsInfo> Emails { get; set; }

        [Region(Title = "Telefones", ListTitle = "Title", Description = "Telefones")]
        public IList<PhoneInfo> Phones { get; set; }

           [Region(Title = "Morada", ListTitle = "Title", Description = "Morada")]
        public 
        AddressInfo Address { get; set; }



    }




}

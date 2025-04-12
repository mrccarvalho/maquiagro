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
    [ContentType(Title = "Atrelados", UsePrimaryImage = false, UseExcerpt = false)]

    public class AtreladoMaquina : Maquina<AtreladoMaquina>
    {

        [Region (Title = "Dados Gerais da Máquina")]
        public ProductInfo ProductInfo { get; set; }

        [Region (Title = "Especificações")]
        public ProductSpecification ProductSpecification { get; set; }


        [Region (Title = "Imagens da Máquina", ListTitle = "BigImage")]
        public IList<ProductImage> MachineImages { get; set; }




    }




}

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
using PiranhaCMS.Validators.Attributes;
using System.ComponentModel.DataAnnotations;
using PiranhaCMS.Models;

namespace PiranhaCMS.ContentTypes.Regions
{
    /// <summary>
    /// Hero region.
    /// </summary>
    public class Hero
    {

         public Hero()
        {
            CssClass = new SelectField<HeroCssClass>
            {
                Value = HeroCssClass.Small
            };
        }


          /// <summary>
        /// Gets/sets Título.
        /// </summary>
        [Field(Title = "Título")]

        public StringField Title { get; set; }

        /// <summary>
        /// Gets/sets optional subtítulo.
        /// </summary>
        [Field(Title = "SubTítulo")]

        public StringField SubTitle { get; set; }

             /// <summary>
        /// Gets/sets optional subsubtítulo.
        /// </summary>
        [Field(Title = "Descrição")]

        public StringField Description { get; set; }

        /// <summary>
        /// Gets/sets optional Datas.
        /// </summary>
        [Field(Title = "Datas", Options = FieldOption.HalfWidth)]

        public StringField Dates { get; set; }

        /// <summary>
        /// Gets/sets  optional Local.
        /// </summary>
        [Field(Title = "Local", Options = FieldOption.HalfWidth)]

        public StringField Local { get; set; }


        /// <summary>
        /// Gets/sets the optional ingresso.
        /// </summary>
        [Field(Title = "Aviso")]

        public HtmlField Ingress { get; set; }

        /// <summary>
        /// Gets/sets the optional primary image.
        /// </summary>
        [Field(Title = "Imagem de Fundo")]

        public ImageField PrimaryImage { get; set; }

           [Field(Title = "Hero style")]
        public SelectField<HeroCssClass> CssClass { get; set; }

    }
}

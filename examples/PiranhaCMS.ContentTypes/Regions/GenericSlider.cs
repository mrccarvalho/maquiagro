/*
 * Copyright (c) 2017-2018 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/tidyui/coreweb
 *
 */

using System.ComponentModel.DataAnnotations;
using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using PiranhaCMS.Models;
using PiranhaCMS.Validators.Attributes;
namespace PiranhaCMS.ContentTypes.Regions
{
    /// <summary>
    /// Hero region.
    /// </summary>
    public class GenericSlider
    {

        public GenericSlider()
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
        /// Gets/sets Título.
        /// </summary>
        [Field(Title = "Título 2")]

        public StringField Title2 { get; set; }
        /// <summary>
        /// Gets/sets Título.
        /// </summary>
        [Field(Title = "Título 3")]

        public StringField Title3 { get; set; }

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

        [Field(Title = "Imagem", Options = FieldOption.HalfWidth)]
        public ImageField ImageBanner { get; set; }

        [Field(Title = "Link Página", Options = FieldOption.HalfWidth)]
        public PageField PageLink { get; set; }

        /// <summary>
        /// Gets/sets the optional primary image.
        /// </summary>
        [Field(Title = "Imagem de Fundo")]

        public ImageField PrimaryImage { get; set; }

        [Field(Title = "Hero style")]
        public SelectField<HeroCssClass> CssClass { get; set; }

    }
}

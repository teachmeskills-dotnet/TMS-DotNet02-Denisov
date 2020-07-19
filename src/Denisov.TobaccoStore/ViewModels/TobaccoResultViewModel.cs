using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Denisov.TobaccoStore.ViewModels
{
    /// <summary>
    /// Model which is used for generated tobacco result.
    /// </summary>
    public class TobaccoResultViewModel
    { 
        /// <summary>
        /// Tobacco picture.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Tobacco name.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Tobacco strength.
        /// </summary>
        [Required]
        public string Strength { get; set; }

        /// <summary>
        /// Tobacco flavour.
        /// </summary>
        [Required]
        public string Flavour { get; set; }

        /// <summary>
        /// Tobacco price.
        /// </summary>
        [Required]
        public float Price { get; set; }

        /// <summary>
        /// Tobacco weight.
        /// </summary>
        [Required]
        public int Weight { get; set; }

    }
}

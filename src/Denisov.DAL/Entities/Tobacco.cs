using Denisov.Common.Interfaces;
using System.Collections.Generic;

namespace Denisov.DAL.Entities
{
    /// <summary>
    /// Class which describes generalized information about the tobacco.
    /// </summary>
    public class Tobacco : IHasIdentifier, IHasName
    {
        /// <summary>
        /// Tobacco identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Tobacco image url.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Tobacco name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Tobacco strength.
        /// </summary>
        public string Strength { get; set; }

        /// <summary>
        /// Tobacco flavour.
        /// </summary>
        public string Flavour { get; set; }

        /// <summary>
        /// Type of tobacco leaf.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Tobacco price.
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Tobacco weight.
        /// </summary>
        public int Weight { get; set; }


        /// <summary>
        /// Saved tobacco list.
        /// </summary>
        public List<SavedTobacco> SavedTobaccos { get; set; }

        /// <summary>
        /// Firm list.
        /// </summary>
        public List<Firm> Firms { get; set; }

        /// <summary>
        /// Tobacco mix list.
        /// </summary>
        public List<TobaccoMix> TobaccoMixes { get; set; }
    }
}

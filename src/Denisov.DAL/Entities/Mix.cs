using Denisov.Common.Interfaces;
using System.Collections.Generic;

namespace Denisov.DAL.Entities
{
    /// <summary>
    /// Class which describes generalized information about the mix.
    /// </summary>
    public class Mix : IHasIdentifier, IHasName
    {
        /// <summary>
        /// Mix identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Mix image url.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Mix name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Mix strength.
        /// </summary>
        public string Strength { get; set; }

        /// <summary>
        /// Mix flavour.
        /// </summary>
        public string Flavour { get; set; }

        /// <summary>
        /// Mix description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Saved mix list.
        /// </summary>
        public List<SavedMix> SavedMixes { get; set; }

        /// <summary>
        /// Tobacco mix list.
        /// </summary>
        public List<TobaccoMix> TobaccoMixes { get; set; }
    }
}

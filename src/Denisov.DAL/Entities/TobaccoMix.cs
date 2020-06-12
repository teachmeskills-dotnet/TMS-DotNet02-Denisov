using Denisov.Common.Interfaces;

namespace Denisov.DAL.Entities
{
    /// <summary>
    /// Class which describes generalized information about the firm.
    /// </summary>
    public class TobaccoMix : IHasIdentifier
    {
        /// <summary>
        /// Tobacco mix identifier.
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// Tobacco identifier.
        /// </summary>
        public int TobaccoId { get; set; }

        /// <summary>
        /// Tobacco entity.
        /// </summary>
        public Tobacco Tobacco { get; set; }

        /// <summary>
        /// Mix identifier.
        /// </summary>
        public int MixId { get; set; }

        /// <summary>
        /// Mix entity.
        /// </summary>
        public Mix Mix { get; set; }
    }
}

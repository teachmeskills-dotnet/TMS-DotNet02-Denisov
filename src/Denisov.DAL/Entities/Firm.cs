using Denisov.Common.Interfaces;

namespace Denisov.DAL.Entities
{
    /// <summary>
    /// Class which describes generalized information about the firm.
    /// </summary>
    public class Firm : IHasIdentifier, IHasName
    {
        /// <summary>
        /// Firm identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Firm name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Firm location.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Tobacco identifier.
        /// </summary>
        public int TobaccoId { get; set; }

        /// <summary>
        /// Tobacco entity.
        /// </summary>
        public Tobacco Tobacco { get; set; }
    }
}

using Denisov.Common.Interfaces;

namespace Denisov.DAL.Entities
{
    /// <summary>
    /// Class which describes generalized information about the saved tobacco.
    /// </summary>
    public class SavedTobacco : IHasIdentifier
    {
        /// <summary>
        /// Saved tobacco identidier.
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// User identifier.
        /// </summary>
        public string UserId { get; set; }

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

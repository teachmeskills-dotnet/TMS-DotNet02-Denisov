using Denisov.Common.Interfaces;

namespace Denisov.DAL.Entities
{
    /// <summary>
    /// Class which describes generalized information about the saved mix.
    /// </summary>
    public class SavedMix : IHasIdentifier
    {
        /// <summary>
        /// Saved mix identifier.
        /// </summary>
        public int Id { get; set; }


        /// <summary>
        /// User identifier.
        /// </summary>
        public string UserId { get; set; }

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

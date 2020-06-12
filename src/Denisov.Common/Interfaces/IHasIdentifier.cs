namespace Denisov.Common.Interfaces
{
    /// <summary>
    /// Interface of entity identifier (for DB context use).
    /// </summary>
    public interface IHasIdentifier
    {
        /// <summary>
        /// Entity identifier.
        /// </summary>
        public int Id { get; set; }
    }
}

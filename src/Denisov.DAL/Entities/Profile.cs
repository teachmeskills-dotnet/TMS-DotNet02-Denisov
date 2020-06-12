using Denisov.Common.Interfaces;
using System;

namespace Denisov.DAL.Entities
{
    /// <summary>
    /// Class which describes generalized information about the profile.
    /// </summary>
    public class Profile : IHasIdentifier
    {
        /// <summary>
        /// Profile identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Profile first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Profile second name.
        /// </summary>
        public string SecondName { get; set; }

        /// <summary>
        /// Profile middle name.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Profile birth date.
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Was profile deleted or not.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Was profile blocked or not.
        /// </summary>
        public bool IsBlocked { get; set; }


        /// <summary>
        /// User identifier.
        /// </summary>
        public string UserId { get; set; }
    }
}

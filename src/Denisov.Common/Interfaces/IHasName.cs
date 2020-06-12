using System;
using System.Collections.Generic;
using System.Text;

namespace Denisov.Common.Interfaces
{
    /// <summary>
    /// Interface which allow to add name to certain entities.
    /// </summary>
    public interface IHasName
    {
        /// <summary>
        /// Entity name.
        /// </summary>
        public string Name { get; set; }
    }
}

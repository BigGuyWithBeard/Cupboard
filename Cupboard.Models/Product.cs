// /*
// * PROJECT:    Cupboard.Models
// * NAME:        Product.cs
// */

using System;

namespace Cupboard.Models
{
    /// <summary>
    /// a Product represents a specific version of a general <see cref="Item"/>, ie 'Warburtons Farmhouse' as opposed to the general 'Bread'
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid Id     { get; set; }
        /// <summary>
        /// Gets or sets the item identifier.
        /// </summary>
        /// <value>
        /// The item identifier.
        /// </value>
        public Guid ItemId { get; set; }
    }
}
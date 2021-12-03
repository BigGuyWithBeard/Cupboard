// /*
// * PROJECT:    Cupboard.Models
// * NAME:        Item.cs
// */

using System;

namespace Cupboard.Models
{
    /// <summary>
    ///     an Item represents a general cupboard Item, as opposed to a specific <see cref="Product"></see>, ie 'Bread' as opposed to the specific 'Warburtons Farmhouse'
    /// </summary>
    public class Item
    {
        /// <summary>
        /// primary identifier
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// name of item
        /// </summary>
        public string Name { get; set; }
    }
}
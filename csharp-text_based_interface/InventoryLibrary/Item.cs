using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// Represents an item in the inventory.
    /// </summary>
    public class Item : BaseClass
    {
        /// <summary>Name of the item (required)</summary>
        public string name { get; set; }

        /// <summary>Description of the item (optional)</summary>
        public string description { get; set; } = "";

        /// <summary>Price of the item (optional), limited to 2 decimal places</summary>
        public float price { get; set; } = 0.0f;

        /// <summary>Tags associated with the item (optional)</summary>
        public List<string> tags { get; set; } = new List<string>();

        /// <summary>Item constructor</summary>
        /// <param name="name">Name (required)</param>
        public Item(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Item name is required.");
            this.name = name;
        }
    }
}

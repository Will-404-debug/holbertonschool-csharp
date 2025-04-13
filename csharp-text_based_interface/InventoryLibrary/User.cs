using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Represents a user in the inventory system.
    /// </summary>
    public class User : BaseClass
    {
        /// <summary>User's name (required)</summary>
        public string name { get; set; }

        /// <summary>User constructor</summary>
        /// <param name="name">Name (required)</param>
        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("User name is required.");
            this.name = name;
        }
    }
}

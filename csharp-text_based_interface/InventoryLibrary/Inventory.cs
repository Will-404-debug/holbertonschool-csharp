using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Represents the association of a user with an item and its quantity.
    /// </summary>
    public class Inventory : BaseClass
    {
        /// <summary>ID of the user (required)</summary>
        public string user_id { get; set; }

        /// <summary>ID of the item (required)</summary>
        public string item_id { get; set; }

        /// <summary>Quantity (required, default 1, cannot be less than 0)</summary>
        public int quantity { get; set; } = 1;

        /// <summary>Inventory constructor</summary>
        public Inventory(string userId, string itemId, int quantity = 1)
        {
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(itemId))
                throw new ArgumentException("User ID and Item ID are required.");

            if (quantity < 0)
                throw new ArgumentException("Quantity cannot be negative.");

            this.user_id = userId;
            this.item_id = itemId;
            this.quantity = quantity;
        }
    }
}

using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Base class for all models
    /// </summary>
    public class BaseClass
    {
        /// <summary>Unique ID of the object</summary>
        public string id { get; set; }

        /// <summary>Creation timestamp</summary>
        public DateTime date_created { get; set; }

        /// <summary>Last update timestamp</summary>
        public DateTime date_updated { get; set; }

        /// <summary>Constructor initializes default values</summary>
        public BaseClass()
        {
            id = Guid.NewGuid().ToString();
            date_created = DateTime.Now;
            date_updated = DateTime.Now;
        }
    }
}

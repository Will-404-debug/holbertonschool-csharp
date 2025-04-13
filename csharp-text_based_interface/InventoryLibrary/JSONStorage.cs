using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InventoryLibrary
{
    /// <summary>
    /// Handles storing and loading objects from a JSON file
    /// </summary>
    public class JSONStorage
    {
        private string filePath = "storage/inventory_manager.json";

        /// <summary>
        /// Dictionary of all stored objects (ClassName.id → object)
        /// </summary>
        public Dictionary<string, BaseClass> objects { get; private set; } = new Dictionary<string, BaseClass>();

        /// <summary>
        /// Returns the objects dictionary
        /// </summary>
        public Dictionary<string, BaseClass> All()
        {
            return objects;
        }

        /// <summary>
        /// Adds a new object to storage
        /// </summary>
        /// <param name="obj">Object to add</param>
        public void New(BaseClass obj)
        {
            string key = obj.GetType().Name + "." + obj.id;
            objects[key] = obj;
        }

        /// <summary>
        /// Saves objects to a JSON file
        /// </summary>
        public void Save()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IncludeFields = true
            };

            Directory.CreateDirectory("storage");

            string json = JsonSerializer.Serialize(objects, options);
            File.WriteAllText(filePath, json);
        }

        /// <summary>
        /// Loads objects from a JSON file
        /// </summary>
        public void Load()
        {
            if (!File.Exists(filePath))
                return;

            string json = File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            // You would typically use custom converters here for polymorphism.
            // As per project instructions, assuming basic dictionary structure:
            objects = JsonSerializer.Deserialize<Dictionary<string, BaseClass>>(json, options) ?? new Dictionary<string, BaseClass>();
        }
    }
}

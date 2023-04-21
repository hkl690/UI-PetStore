using System;
using System.IO;

namespace PetStore.Objects
{


    public class Item
    {
        public string Species { get; set; }
        public double Price { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Picture { get; set; }
        public Uri PictureFilePath { get; set; }

        public Item(string species, double price, string itemName, string category, string description, string picture)
        {
            Species = species;
            Price = price;
            ItemName = itemName;
            Category = category;
            Description = description;
            Picture = picture;            
            PictureFilePath = new Uri("file:///" + Directory.GetCurrentDirectory() + picture);
        }

    }
}

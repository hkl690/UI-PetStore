namespace PetStore
{


    public class Item
    {
        public string Species { get; set; }
        public double Price { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }

        public System.Drawing.Image Picture { get; set; }

        public string Description { get; set; }

        public Item(string species, double price, string itemName, string category, System.Drawing.Image picture, string description)
        {
            Species = species;
            Price = price;
            ItemName = itemName;
            Category = category;
            Picture = picture;
            Description = description;
        }

    }
}

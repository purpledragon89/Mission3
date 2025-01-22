namespace ConsoleApp3
{
    public class FoodItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }

        // Constructor to initialize food item properties
        public FoodItem(string name, string category, int quantity, DateTime expirationDate)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            ExpirationDate = expirationDate;
        }

        // Override ToString for better display
        public override string ToString()
        {
            return $"{Name} | {Category} | {Quantity} units | Expiration: {ExpirationDate:yyyy-MM-dd}";
        }
    }
}
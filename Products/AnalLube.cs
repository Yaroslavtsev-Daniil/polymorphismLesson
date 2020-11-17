namespace SexShop.Products
{
    class AnalLube : Product
    {
        public AnalLube(string name, int price, string manufacturer)
        {
            Category = "Для попы";
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }
    }
}

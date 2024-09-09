namespace Polymorph2
{
    class Program
    {
        static void Main()
        {
            var products = new List<Product>
        {
            new Toy("Bear", 29, "3-5 years"),
            new Meat("Chicken", 12, "Poultry"),
            new Drinks("Juice", 3, false),
            new Drinks("Milk", 5, true),
            new Electronics("Smartphone", 299, "2 years"),
            new Clothes("T-Shirt", 27, "M", "Black")
        };




            foreach (var product in products)
            {

                Console.WriteLine(product.GetInformation());

            }
        }
    }
}

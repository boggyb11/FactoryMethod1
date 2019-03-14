using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ChickenCreator[] creators = new ChickenCreator[2];
            creators[0] = new RapChickenCreator();
            creators[1] = new MmaChickenCreator();

            foreach (var creator in creators)
            {
                Chicken product = creator.FactoryMethod();
                Console.WriteLine($"Created {product.Name}");
            }
            Console.ReadLine();
        }
    }
}

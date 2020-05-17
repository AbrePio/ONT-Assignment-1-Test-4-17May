using System;

namespace ONT_4_Assignment_1_test_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            string ing, kitchen;
            Console.Write("Enter Country (SA/US): ");
            kitchen = Console.ReadLine();
            Console.Write("Do you want to create a Taco or Burrito? ");
            ing = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            if(kitchen == "SA" || kitchen == "sa")
            {
                if(ing == "Taco" || ing == "taco")
                {
                    Taco saTaco = new Taco(new SAIngredientFactory());
                    Console.WriteLine($"SA Taco: {saTaco.DescribeTaco()}");
                }
                else if(ing == "Burrito" || ing == "burrito")
                {
                    Burrito saBurrito = new Burrito(new SAIngredientFactory());
                    Console.WriteLine($"SA Burrito: {saBurrito.DescribeBurrito()}");
                }
                
                
            }
            else if(kitchen == "US" || kitchen == "us")
            {
                if (ing == "Taco" || ing == "taco")
                {
                    Taco usTaco = new Taco(new USIngredientFactory());
                    Console.WriteLine($"US Taco: {usTaco.DescribeTaco()}");
                }else if(ing == "Burrito" || ing == "burrito")
                {
                    Burrito usBurrito = new Burrito(new USIngredientFactory());
                    Console.WriteLine($"US Burrito: {usBurrito.DescribeBurrito()}");
                }
                
                
                
            }

            
            

            
            

            Console.ReadLine();
        }
    }
}

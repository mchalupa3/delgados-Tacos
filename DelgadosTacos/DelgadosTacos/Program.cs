using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelgadosTacos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Delgado's Tacos!");
            TacoTruckImage();
            Console.WriteLine("Would you Like to see the menu?");
            string menuAnswer = Console.ReadLine();
            menuAnswer = menuAnswer.ToLower();
            if (menuAnswer == "yes")
            {
                MenuOptions();
            }
            if (menuAnswer == "no")
            {
                Console.WriteLine("Well then why are you here?");
            }
           
        }

        private static void MenuOptions()
        {
            Console.WriteLine("Menu ");
            Console.WriteLine("Main Meals:");
            Console.WriteLine("World Famous Tacos: 1.50$ per taco");
            Console.WriteLine("Bean Bursting Burritos: 2.50$ per Burrito");
            Console.WriteLine("Tasty Taco Salad: 3.50$ for 1/2 and 5.00$ for full");
            Console.WriteLine("Drinks:");
            Console.WriteLine("Water");
            Console.WriteLine("Pop");
        }

        private static void UserOrder()
        {
            double taco = 1.50;
            double burrito = 2.50;
            double tacoSaladHalf = 3.50;
            double tacoSaladFull = 5;
            double water = 1.25;
            double pop = 1.75;
            double totalNoTax = (taco + burrito + tacoSaladFull + tacoSaladHalf + tacoSaladFull + water + pop);
            double totalWithTax = totalNoTax * 1.07;
            Console.WriteLine("What would you like to order?");
            Console.WriteLine("would you like to order any tacos? If so how many?");

        }

        private static void TacoTruckImage()
        {
            Console.WriteLine(" __________________________");
            Console.WriteLine("|                          |");
            Console.WriteLine("|  Delgado's Tacos!        |");
            Console.WriteLine("|        :)                |____");
            Console.WriteLine("|                               |");
            Console.WriteLine("|   _____              _____    |");
            Console.WriteLine("|__|( . )|____________|( . )|___|");




        }  
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}

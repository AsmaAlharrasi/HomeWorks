using System.Drawing;

namespace HW_2_week_2
{
    class Program
    {

        static void DisplayMenu ( )
        {

            string[] coffee = { "Latte", "Cappuccino", "Amreicano" };
            double[] price = { 3.50, 3.00, 2.50 };
            string[] size = { "Small", "Medium", "Large" };

            Console.WriteLine($"Menu :\n 1.{coffee[0]} -- {price[0]}\n  2.{ coffee[1]} -- { price[1]}\n 3.{coffee[2]} -- {price[2]}");
            Console.WriteLine("Please enter the desired Drink from (1-3)");

        }

        static void PlaceOrder (  string size, string suger , string milk )
        {

            string[] Size = { "Latte", "Cappuccino", "Amreicano" };
            string[] Suger = { "with suger" , "without suger" };
            string[] Milk = { "with milk" , "without milk" };



        }

        static void CalculateCost( string coffee, string size)
        {

        }

        static void displayOrderSummary( string coffee, string size, bool sugar, bool milk, double total)
        {

        }
        static void Main()
        {
            DisplayMenu();
        }
    }
}

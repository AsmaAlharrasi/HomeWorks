namespace HW_2_week_2
{
    class Program
    {

        static void DisplayMenu ( )
        {

            string[] coffee = { "Latte", "Cappuccino", "Amreicano" };
            double[] price = { 3.50, 3.00, 2.50 };
            
            Console.WriteLine($"Menu :\n 1.{coffee[0]} -- {price[0]}\n  2.{ coffee[1]} -- { price[1]}\n 3.{coffee[2]} -- {price[2]}");
            Console.WriteLine("Please enter the desired Drink from (1-3)");
            int value = Convert.ToInt32(Console.ReadLine());
        }

        static string PlaceOrder ( out string size, out string sugar , out string milk )
        {

            string[] Size = { "small" , "medium" , "larg" };
            

            Console.WriteLine($"Customizations :\n 1.{Size[0]}\n  2.{Size[1]}\n 3.{Size[2]}");
            Console.WriteLine("Select size from (1-3)");
            int value = Convert.ToInt32(Console.ReadLine());

            string MilkValue;
            string SugarValue;

            Console.WriteLine($"Do you want sugar? (yes/No):");
            string val1 = Console.ReadLine();
            SugarValue = (val1.ToLower() == "yes") ? "With Sugar" : "Without Sugar ";


            Console.WriteLine($"Do you want milk? (yes/No):");
            string val2 = Console.ReadLine();
            MilkValue = (val2.ToLower() == "yes") ? "With Milk " : "Without Milk ";


            Console.Write("Enter your choice (1-3): ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice >= Size.Length)
            {
                Console.Write("Invalid choice. Enter a number between 1 and 3: ");
            }

            size = Size[choice - 1];
            sugar = SugarValue;
            milk = MilkValue;

            return size;


        }

        static double CalculateCost( string coffee, string size)
        {
            
            double smallPrice = 2.50;
            double mediumPrice = 3.00;
            double largePrice = 3.50;

            
            double cost = 0.0;
            switch (size.ToLower())
            {
                case "small":
                    cost = smallPrice;
                    break;
                case "medium":
                    cost = mediumPrice;
                    break;
                case "large":
                    cost = largePrice;
                    break;
                default:
                    Console.WriteLine("Invalid size. Unable to calculate cost.");
                    break;
            }

            

            return cost;
        }

        static void DisplayOrderSummary(string coffee, string size, string sugar, string milk, double total)
        {
            Console.WriteLine("\nOrder Summary:");
            Console.WriteLine($"Coffee: {coffee}");
            Console.WriteLine($"Size: {size}");
            Console.WriteLine($"Sugar: {sugar}");
            Console.WriteLine($"Milk: {milk}");
            Console.WriteLine($"Total Cost: ${total}");
        }

        static void Main()
        {

            Console.WriteLine("Welcome to the Coffee Shop!\n");
            while (true)
            {
                DisplayMenu();

                string selectedCoffee = PlaceOrder(out string size, out string sugar, out string milk);

                double totalCost = CalculateCost(selectedCoffee, size);

                DisplayOrderSummary(selectedCoffee, size, sugar, milk, totalCost);

                Console.WriteLine("\nDo you want to place another order? (yes/No):");
                string continueOrder = Console.ReadLine().Trim().ToLower();

                if (continueOrder != "yes")
                {
                    Console.WriteLine("\nThank you for visiting the Coffee Shop! Goodbye!");
                    break;
                }
            }
        }
    }
}

namespace coffee_shop
{
    class Program
    {
        static void Main()

        {
            Console.WriteLine("Hi Everyone, Welcome to Our GREAT Coffee Shop!");

            //Coffee Menu Display


            double AmericanoPrice = 2.50;
            double LattePrice = 3.00;
            double CappuccinoPrice = 3.50;

            Console.WriteLine("Menu:\n" +
                "1.Americano - $" + AmericanoPrice +
                "\n2.Latte - $" + LattePrice +
                "\n3.Cappucciino -$" + CappuccinoPrice);

            Console.WriteLine("\nChoose Your Fav Coffee (1-3) :");

            int UserChoice = Convert.ToInt32(Console.ReadLine());


            if (UserChoice == 1)
            {
                Console.WriteLine("Americano");
            }

            else if (UserChoice == 2)
            {
                Console.WriteLine("Latte");
            }

            else

            {
                Console.WriteLine("Cappuccino");

            }

            Console.WriteLine("your choice is:" + UserChoice);


            //Coffee Customizations

            string Size1 = "Small";
            string Size2 = "Medium";
            string Size3 = "Large";

            Console.WriteLine("\nCustomizations:\n" +
                "1." + Size1 +
                "\n2." + Size2 +
                "\n3." + Size3);

            Console.WriteLine("\nChoose The size (1-3) :");
            int Size = Convert.ToInt32(Console.ReadLine());


            if (Size == 1)
            {
                Console.WriteLine("Small");
            }

            else if (Size == 2)
            {
                Console.WriteLine("Medium");
            }

            else

            {
                Console.WriteLine("Larg");
            }

            Console.WriteLine("the size of your Coffee is:" + Size);




            Console.WriteLine("\nDo you want Suger (Yes/No):");
            string suger = Console.ReadLine().Trim().ToLower();
            if (suger == "yes")
            {
                Console.WriteLine("with suger");
            }
            else if (suger == "no")
            {
                Console.WriteLine("without suger");
            }


            Console.WriteLine("\nDo you want Suger (Yes/No):");
            string milk = Console.ReadLine().Trim().ToLower();
            if (milk == "yes")
            {
                Console.WriteLine("with milk");
            }
            else if (milk == "no")
            {
                Console.WriteLine("without milk");
            }




            //Order Summary

            Console.WriteLine("Summery Order:" + UserChoice + Size + suger + milk);

        }
    }
}
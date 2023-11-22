namespace HW_1_week_2
{
    class Program
    {
        static string[] Products = new string[100];
        static decimal[] Prices = new decimal[100];
        static int[] Quantities = new int[100];
        static int Count = 0;
        static int TSales = 0;
        static decimal TRevenue = 0;
        static int productnum = 0;

       
        static void AddProduct()
        {
            
            Console.WriteLine("Enter product name:");
            string product = Console.ReadLine();
            
            Console.WriteLine("Enter product price:");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            

            Console.WriteLine("Enter product quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());
           

            Products[Count] = product;
            Prices[Count] = price;
            Quantities[Count] = quantity;
            Count++;

            Console.WriteLine("Product added successfully!");

        }

        static void UpdateQuantity()
        {
            Console.WriteLine("Enter product name:");
            string Product = Console.ReadLine();
            Console.WriteLine();




            if (productnum != -1)
            {
                Console.Write("Enter quantity to add/subtract: ");
                int Change = Convert.ToInt32(Console.ReadLine());
                Quantities[productnum] += Change;
                Console.WriteLine("Quantity updated successfully!");
            }
            else
            {
                Console.WriteLine("Product not found. Use option 1 to add a new product.");
            }


        }

        static void DisplayList()
        {
            Console.WriteLine("Product List:");

            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine("price:" + Prices[i] + "Quantity:" + Quantities[i]);
                
            }


        }

        static void RecordSale()
        {
            Console.WriteLine("Enter product name:");
            string product = Console.ReadLine();
            Console.WriteLine(product);

            Console.WriteLine("Enter quantity sold:");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(quantity);
        }

        static void ProductReport()
        {

        }
        
        static void SalesReport()
        {
            Console.WriteLine($"Sales Report:\nTotal Sales: {TSales}\nTotal Revenue: ${TRevenue}");
        }
        
        static void Main()
        {

            Console.WriteLine("WELCOME TO THE INVENTORY MANAGEMENT SYSTEM \n");

            Console.WriteLine("Please enter your username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Please enter your password: ");
            string password = Console.ReadLine();

            if (username == "admin" && password == "adminpass")
            {
                Console.WriteLine("Authentication successful! Welcome, admin!");
            }
            else
            {
                Console.WriteLine("Please Enter a CORRECT User Name or Password!!!");
            }


            Console.WriteLine("\nOptions:\n1. Add product\n2. Update quantity\n3. Display products\n4. Record sale\n5. Generate product report\n" +
                "6. Generate sales report\n7. Exit");

            Console.Write("Select (1-7): ");
            int userchoice = Convert.ToInt32(Console.ReadLine());


            int choice = 0;

            if (choice == 1)
            {
                AddProduct();
            }
            else if (choice == 2)
            {
                UpdateQuantity();
            }
            else if (choice == 3)
            {
                DisplayList();
            }
            else if (choice == 4)
            {
                RecordSale();
            }
            else if (choice == 5)
            {
                ProductReport();
            }
            else if (choice == 6)
            {
                SalesReport();
            }
            else if (choice == 7)
            {
                Console.WriteLine("Thank you for using the Inventory Management System, admin"); ;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid operation.");
            }

            Console.WriteLine(userchoice);


        }




    }
    
}

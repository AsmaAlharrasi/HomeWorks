namespace Zoo_Animal_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            Console.WriteLine("Welcome to the Minimalist Zoo Animal Management System!");
            Console.WriteLine("1. Add Animals to the Zoo");
            Console.Write("Enter Animal Name: ");
            string Name = Console.ReadLine();

            Console.Write("Enter Animal Age: ");
            int Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Animal Species: ");
            string Species = Console.ReadLine();

            Console.WriteLine("Select Animal Diet Type (1. Carnivore, 2. Herbivore, 3. Omnivore):");
            DietType DietType = (DietType)Enum.Parse(typeof(DietType), Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------------------");

            Mammal lion = new Mammal(Name, Age, Species, DietType, "Golden");
            zoo.AddAnimal(lion, "Mammal Enclosure");

            Console.WriteLine("2. Display Zoo Animals:");
            zoo.DisplayEnclosure("Mammal Enclosure");
            Console.WriteLine();

            Console.WriteLine("3. Add More Animals:");
            Console.Write("Enter Animal Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Animal Age: ");
            Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Animal Species: ");
            Species = Console.ReadLine();

            Console.WriteLine("Select Animal Diet Type (1. Carnivore, 2. Herbivore, 3. Omnivore):");
            DietType = (DietType)Enum.Parse(typeof(DietType), Console.ReadLine());

           
            Console.WriteLine("---------------------------------------------------------------------");

            Bird eagle = new Bird(Name, Age, Species, DietType, true);
            zoo.AddAnimal(eagle, "Bird Enclosure");

            Console.WriteLine("4. Display Zoo Animals:");
            zoo.DisplayEnclosure("Mammal Enclosure");
            zoo.DisplayEnclosure("Bird Enclosure");
            Console.WriteLine();

            Console.WriteLine("5. Observe Animal Actions:");
            lion.MakeSound();
            eagle.Move();
            Console.WriteLine();

            Console.WriteLine("6. Exit");
            Console.WriteLine("Thank you for using the Minimalist Zoo Animal Management System!");
        }  
        
    }
}
   


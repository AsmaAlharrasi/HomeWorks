namespace HM_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Simple Calculator");

            while (true)
            {
                Console.WriteLine("Options:\n" + "1.Addition\n" + "2.Subtraction\n" + 
                    "3.Multiplication\n" + "4.Division\n" + "5.Exit\n");

                int select = Convert.ToInt32(Console.ReadLine());
                int result = 0;

                string ope = (select >= 1 && select <= 4) ? " enter the first ope: " : "enter the second ope: ";
                
                int ope1 = Convert.ToInt32(Console.ReadLine());
                int ope2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(ope);

                    

                    if (select == 1)
                    {
                        result = ope1 + ope2;
                    }

                    else if (select == 2)
                    {
                        result = ope1 - ope2;
                    }

                    else if ( select == 3)
                    {
                        result = ope1 * ope2;

                    }

                    else if (select == 4)
                    {
                        result = ope1 / ope2;
                    }

                    break;

                                
            }

                 Console.WriteLine("performe another ope? (yes/No)");
                 string countinueselect = Console.ReadLine();
            
        }
    }
}
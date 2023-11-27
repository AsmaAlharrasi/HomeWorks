using System.Numerics;

namespace HW1_week3
{
    internal class Program
    {
        static void PlayerMovement()
        {
            string[] S = { "R", "L", "D", "U" };
            Console.WriteLine("Enter your move (U/L/D/R):");
            string position = Console.ReadLine();

            int i = 0 ;
            int j=0;

            if (position == "R")
            {
                ++j;
            }
            else if (position == "L")
            {
                --j;
            }
            else if (position == "D")
            {
                ++i;
            }
            else if (position == "U")
            {
                --i;
            }
            else
            {
                Console.WriteLine("PLEASE ENTER ONE OF THESE LETTERS ( R / L / D / U ) ");
            }
        }
        static void Main()
        {
            Console.WriteLine("Welcome to the Maze Escape Challenge!\r\nGenerated Maze:");

            string[,] MazeArray = new string[5, 7];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (i == 0 || j == 0 || j == 6)
                    {
                        Console.Write("#");
                    }
                    else if ((i == 4 && j == 5))
                    {
                        Console.Write("\nE");
                    }
                    else
                    {
                        Console.Write("\n ");
                    }
                }
            }

            Console.WriteLine("Use ( R - L - U - D ) to move. Your goal is to reach the Exit (E)!");
            PlayerMovement();

            string[] S = { "R", "L", "D", "U" };
            Console.WriteLine("Enter your move (U/L/D/R):");
            string position = Console.ReadLine();

            

            Console.WriteLine("Do you want to play again? (N/Y)");
            string again = Console.ReadLine();

            if ( again == "N")
            Console.WriteLine("Thank you for playing the Maze Escape Challenge!");
            
            
            Console.ReadKey();
            
        }
    }
}
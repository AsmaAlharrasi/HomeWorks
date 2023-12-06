using System.Data.Common;
using System.Numerics;

namespace HW1_week3
{
    internal class Program
    {
        static void Main()
        {
            MazeGame maze = new MazeGame();

            Console.WriteLine("Welcome to the Maze Escape Challenge!");

            do
            {
                maze.DisplayMaze();
                maze.PlayerMovement();

                if (!maze.IsValidMove())
                {
                    Console.WriteLine("Invalid move. You hit a wall!");
                    continue;
                }

                if (maze.Row == 4 && maze.Column == 5)
                {
                    maze.Won = true;
                    break;
                }

            } while (!maze.Won);

            Console.WriteLine($"Congratulations! You've reached the Exit (E)!");
            Console.WriteLine("Do you want to play again? (N/Y)");

            string again = Console.ReadLine();

            if (again == "N")
                Console.WriteLine("Thank you for playing the Maze Escape Challenge!");
        }

    }
}
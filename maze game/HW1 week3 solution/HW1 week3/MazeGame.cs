using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_week3
{
    internal class MazeGame
    {
        public int Row;
        public int Column;
        public bool Won;

        public MazeGame()
        {
              
        }

        public MazeGame(int Row, int Column, bool Won)
        {
            this.Row = Row;
            this.Column = Column;
            this.Won = Won;
        }

        public void DisplayMaze()
        {
            Console.WriteLine("Generated Maze:");

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
                        Console.Write(" E");
                    }
                    else if (i == this.Row && j == this.Column)
                    {
                        Console.Write("S");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
             Console.WriteLine("Use ( R - L - U - D ) to move. Your goal is to reach the Exit (E)!");
        }


        public void PlayerMovement()
        {
            Console.WriteLine("Enter your move (U/L/D/R):");
            string position = Console.ReadLine().ToUpper();

            
            if (position == "R")
            {
                this.Column++;
            }
            else if (position == "L")
            {
                this.Column--;
            }
            else if (position == "D")
            {
                this.Row++;
            }
            else if (position == "U")
            {
                this.Row--;
            }
            else
            {
                Console.WriteLine("PLEASE ENTER ONE OF THESE LETTERS ( R / L / D / U ) ");
            }
        }

        public bool IsValidMove()
        {
            return this.Row >= 0 && this.Row < 5 &&
                   this.Column >= 0 && this.Column < 7;
        }

    }
}
